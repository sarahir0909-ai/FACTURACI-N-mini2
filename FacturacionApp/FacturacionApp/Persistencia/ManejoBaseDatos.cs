using FacturacionApp.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApp.Persistencia
{
    public class ManejoBaseDatos
    {
        private string _rutaBaseDatos;
        public ManejoBaseDatos()
        {
            _rutaBaseDatos = System.IO.Path.Combine(AppContext.BaseDirectory, "Facturacion.db");
        }

        // Crear la base de datos y su tabla
        public void CrearBaseDatos()
        {
            using (SqliteConnection conexion = new SqliteConnection("Data Source=" + _rutaBaseDatos))
            {
                conexion.Open();

                using (SqliteCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText =
                    @"CREATE TABLE IF NOT EXISTS Paquetes
                (
                    Codigo TEXT PRIMARY KEY,
                    Cliente TEXT NOT NULL,
                    Zona TEXT NOT NULL,
                    Peso REAL NOT NULL,
                    ValorDeclarado REAL NOT NULL,
                    SubtotalPeso REAL NOT NULL,
                    RecargoZona REAL NOT NULL,
                    PenalizacionPeso REAL NOT NULL,
                    Seguro REAL NOT NULL,
                    Impuesto REAL NOT NULL,
                    CostoFijo REAL NOT NULL,
                    Total REAL NOT NULL,
                    FechaRegistro TEXT NOT NULL
                );";

                    comando.ExecuteNonQuery();
                }
            }
        }

        // Comprobar si un paquete ya está registrado
        public bool ExistePaquete(string codigo)
        {
            using (SqliteConnection conexion = new SqliteConnection("Data Source=" + _rutaBaseDatos))
            {
                conexion.Open();
                using (SqliteCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText =
                        "SELECT COUNT(*) FROM Paquetes WHERE Codigo = $codigo;";

                    comando.Parameters.AddWithValue("$codigo", codigo);
                    long cantidad = (long)comando.ExecuteScalar()!;
                    return cantidad > 0;
                }
            }
        }

        // Guardar un paquete y su factura
        public bool GuardarPaquete(ResultadoPaquete resultado)
        {
            if (resultado == null)
                throw new ArgumentNullException(nameof(resultado));

            // Evitar guardar un paquete que ya existe
            if (ExistePaquete(resultado.Paquete.Codigo))
                return false;

            using (SqliteConnection conexion = new SqliteConnection("Data Source=" + _rutaBaseDatos))
            {
                conexion.Open();

                using (SqliteCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText =
                    @"INSERT INTO Paquetes
                (
                    Codigo, Cliente, Zona, Peso, ValorDeclarado,
                    SubtotalPeso, RecargoZona, PenalizacionPeso,
                    Seguro, Impuesto, CostoFijo, Total, FechaRegistro
                )
                VALUES
                (
                    $codigo, $cliente, $zona, $peso, $valor,
                    $subtotal, $recargo, $penalizacion,
                    $seguro, $impuesto, $costoFijo, $total, $fecha
                );";

                    comando.Parameters.AddWithValue("$codigo", resultado.Paquete.Codigo);
                    comando.Parameters.AddWithValue("$cliente", resultado.Paquete.Cliente);
                    comando.Parameters.AddWithValue("$zona", resultado.Paquete.Zona);
                    comando.Parameters.AddWithValue("$peso", resultado.Paquete.Peso);
                    comando.Parameters.AddWithValue("$valor", resultado.Paquete.ValorDeclarado);
                    comando.Parameters.AddWithValue("$subtotal", resultado.Factura.SubtotalPeso);
                    comando.Parameters.AddWithValue("$recargo", resultado.Factura.RecargoZona);
                    comando.Parameters.AddWithValue("$penalizacion", resultado.Factura.PenalizacionPeso);
                    comando.Parameters.AddWithValue("$seguro", resultado.Factura.Seguro);
                    comando.Parameters.AddWithValue("$impuesto", resultado.Factura.Impuesto);
                    comando.Parameters.AddWithValue("$costoFijo", resultado.Factura.CostoFijo);
                    comando.Parameters.AddWithValue("$total", resultado.Factura.Total);
                    comando.Parameters.AddWithValue("$fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Consultar todos los paquetes registrados
        public List<ResultadoPaquete> ObtenerPaquetes()
        {
            List<ResultadoPaquete> resultados = new List<ResultadoPaquete>();

            using (SqliteConnection conexion = new SqliteConnection("Data Source=" + _rutaBaseDatos))
            {
                conexion.Open();

                using (SqliteCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText =
                        @"SELECT Codigo, Cliente, Zona, Peso, ValorDeclarado,
                     SubtotalPeso, RecargoZona, PenalizacionPeso,
                     Seguro, Impuesto, CostoFijo, Total
              FROM Paquetes
              ORDER BY FechaRegistro DESC;";

                    using (SqliteDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Paquete paquete = new Paquete();

                            paquete.Codigo = lector.GetString(0);
                            paquete.Cliente = lector.GetString(1);
                            paquete.Zona = lector.GetString(2);
                            paquete.Peso = Convert.ToDecimal(lector.GetDouble(3));
                            paquete.ValorDeclarado = Convert.ToDecimal(lector.GetDouble(4));

                            DesgloseFactura factura = new DesgloseFactura();

                            factura.SubtotalPeso = Convert.ToDecimal(lector.GetDouble(5));
                            factura.RecargoZona = Convert.ToDecimal(lector.GetDouble(6));
                            factura.PenalizacionPeso = Convert.ToDecimal(lector.GetDouble(7));
                            factura.Seguro = Convert.ToDecimal(lector.GetDouble(8));
                            factura.Impuesto = Convert.ToDecimal(lector.GetDouble(9));
                            factura.CostoFijo = Convert.ToDecimal(lector.GetDouble(10));
                            factura.Total = Convert.ToDecimal(lector.GetDouble(11));

                            ResultadoPaquete resultado = new ResultadoPaquete();

                            resultado.Paquete = paquete;
                            resultado.Factura = factura;

                            resultados.Add(resultado);
                        }
                    }
                }
            }
            return resultados;
        }
    }
}
