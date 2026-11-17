
# 📦 Sistema de Procesamiento y Auditoría de Facturación

**Mini Proyecto 2 — Programación**

Aplicación de escritorio desarrollada en **C# y Windows Forms**, diseñada para procesar, validar y calcular facturas de paquetes de una empresa de logística y entregas.

El sistema permite registrar lotes de paquetes, calcular sus costos de envío, consultar el desglose de cada factura, almacenar el historial en una base de datos y exportar los resultados a archivos CSV.

---

## 1. Descripción general

El sistema recibe información de paquetes mediante registros de texto separados por punto y coma (`;`). Cada registro contiene cinco campos:

| Campo | Descripción |
|---|---|
| Código | Identificador único del paquete |
| Cliente | Nombre del cliente |
| Zona | Zona de entrega (A, B o C) |
| Peso | Peso del paquete en kilogramos |
| Valor declarado | Valor monetario del contenido |

Ejemplo de registro:

```text
PACK-101;Juan Perez;Zona A;12.5;150
```

La aplicación procesa cada línea de manera independiente. Los registros válidos se utilizan para calcular las facturas, mientras que los incorrectos se identifican y muestran en el apartado de errores.

## 2. Funcionalidades principales

### Procesamiento y validación de paquetes

- Captura de múltiples paquetes mediante un campo de texto multilínea.
- Separación y análisis de registros mediante el delimitador `;`.
- Validación de los cinco campos requeridos.
- Comprobación de datos numéricos.
- Detección de campos vacíos, valores negativos y zonas no reconocidas.
- Procesamiento independiente de cada línea para evitar que un registro incorrecto detenga el lote completo.

### Cálculo de facturación

El sistema calcula automáticamente los importes correspondientes a cada paquete:

- Subtotal por peso.
- Recargo según la zona de entrega.
- Penalización por exceso de peso.
- Seguro por valor declarado.
- Impuesto (IVA).
- Costo fijo de envío.
- Total individual de cada factura.

También calcula el importe total correspondiente al lote procesado.

### Interfaz multidioma

La aplicación permite cambiar entre dos idiomas:

- 🇲🇽 Español.
- 🇺🇸 Inglés.

La selección se realiza mediante un `ComboBox` y actualiza los textos de la interfaz, encabezados, botones y mensajes del sistema.

### Consulta y auditoría

Los resultados se presentan en una tabla `DataGridView`, ordenados de mayor a menor importe total.

Al seleccionar un paquete, se muestra el desglose de su factura para facilitar la consulta de los conceptos que conforman el importe final.

### Almacenamiento de información

La aplicación utiliza una base de datos SQLite para conservar el historial de paquetes y sus respectivos cálculos.

La base de datos se crea automáticamente cuando se inicia el sistema. Los registros se almacenan evitando duplicados por código de paquete.

### Exportación de reportes

Permite exportar los resultados a archivos CSV mediante un cuadro de diálogo para seleccionar la ubicación y el nombre del archivo.

El reporte contiene los datos del paquete y el desglose financiero de su factura.

---

## 3. Reglas de cálculo

### Recargos por zona

| Zona de entrega | Recargo |
|---|---:|
| Zona A | 5% |
| Zona B | 10% |
| Zona C | 18% |

El recargo se aplica sobre el subtotal correspondiente al peso.

### Penalización por exceso de peso

Cuando un paquete supera los 20 kg, se aplica una penalización por cada kilogramo adicional.

El importe corresponde al 25% del precio base por kilogramo configurado en el archivo JSON.

### Seguro obligatorio

Cuando el valor declarado supera los $1,000.00, se agrega un seguro equivalente al 2% de dicho valor.

### Configuración financiera

Los parámetros principales se obtienen del archivo `appsettings.json`:

- Precio base por kilogramo.
- Tasa de IVA.
- Costo fijo de envío.

Esto permite modificar los valores de configuración sin alterar directamente la lógica de cálculo.

---

## 4. Tecnologías utilizadas

| Tecnología | Aplicación |
|---|---|
| C# | Lenguaje de programación |
| .NET 10 | Plataforma de desarrollo |
| Windows Forms | Interfaz gráfica |
| SQLite | Almacenamiento de información |
| JSON | Configuración de tarifas |
| CSV | Exportación de reportes |
| Git y GitHub | Control de versiones |

**Dependencia principal:**

- `Microsoft.Data.Sqlite`

---

## 5. Estructura del proyecto

```text
FACTURACI-N-mini2/
│
├── FacturacionApp/
│   │
│   ├── Modelos/
│   │   ├── Paquete.cs
│   │   ├── ResultadoPaquete.cs
│   │   └── DesgloseFactura.cs
│   │
│   ├── Servicios/
│   │   ├── Procesamiento.cs
│   │   ├── Validaciones.cs
│   │   ├── CalculoTarifas.cs
│   │   ├── ArregloPaquetes.cs
│   │   ├── ExportacionCSV.cs
│   │   └── Idiomas.cs
│   │
│   ├── Persistencia/
│   │   ├── ManejoBaseDatos.cs
│   │   └── ConfiguracionArchivo.cs
│   │
│   ├── Recursos/
│   │   └── idiomas.json
│   │
│   ├── appsettings.json
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Program.cs
│   └── FacturacionApp.csproj
│
└── FacturacionApp.sln
```

---

## 6. Instalación y ejecución

### Requisitos

- Windows 10 o superior.
- .NET 10 Desktop Runtime.
- Visual Studio 2022 o superior con soporte para .NET 10, para ejecutar el proyecto desde el entorno de desarrollo.

### Ejecutar desde Visual Studio

1. Descargar o clonar el repositorio.
2. Abrir el archivo `FacturacionApp.sln`.
3. Restaurar los paquetes NuGet.
4. Comprobar que los archivos de configuración y recursos estén incluidos.
5. Compilar la solución.
6. Ejecutar el proyecto mediante `F5`.

### Clonar el repositorio

```bash
git clone https://github.com/sarahir0909-ai/FACTURACI-N-mini2.git
```

Abrir posteriormente el archivo de solución en Visual Studio.

### Ejecución mediante publicación

La aplicación también puede distribuirse mediante una publicación de tipo Release.

En una publicación dependiente del framework se requiere tener instalado .NET 10 Desktop Runtime. En una publicación autocontenida, el runtime se incluye con la aplicación.

---

## 7. Ejemplos de pruebas

Los siguientes registros permiten comprobar el procesamiento, la validación y las reglas de facturación del sistema.

### Prueba 1. Procesamiento de registros válidos

**Entrada:**

```text
PACK-101;Juan Perez;Zona A;12.5;150
PACK-102;Maria Lopez;Zona C;8;200
PACK-103;Pedro Gomez;Zona B;15;1200
```

**Resultado esperado:**

- 3 paquetes válidos.
- 0 errores.
- Cálculo de facturas individuales.
- Ordenamiento de los resultados de mayor a menor importe.

### Prueba 2. Detección de registros incorrectos

**Entrada:**

```text
PACK-201;Luis Torres;Zona A;-5;300
PACK-202;Maria Lopez;Zona C;ABC;200
PACK-203;Pedro Gomez;Zona B;10;1200
PACK-204;Ana Ruiz;Zona A;15
```

**Resultado esperado:**

| Código | Resultado |
|---|---|
| PACK-201 | Rechazado: peso negativo |
| PACK-202 | Rechazado: peso no numérico |
| PACK-203 | Válido |
| PACK-204 | Rechazado: cantidad incorrecta de campos |

- 1 paquete válido.
- 3 errores detectados.
- El registro válido se procesa sin interrupciones.

### Prueba 3. Penalización y seguro

**Entrada:**

```text
PACK-301;Carlos Ruiz;Zona A;25;1500
```

**Resultado esperado:**

- Paquete válido.
- Aplicación de la penalización por superar los 20 kg.
- Aplicación del seguro por superar los $1,000.00 de valor declarado.
- Cálculo de impuestos y total de factura.

### Prueba 4. Comparación de recargos por zona

**Entrada:**

```text
PACK-401;Cliente A;Zona A;10;500
PACK-402;Cliente B;Zona B;10;500
PACK-403;Cliente C;Zona C;10;500
```

**Resultado esperado:**

- 3 paquetes válidos.
- Aplicación de los recargos correspondientes a las zonas A, B y C.
- Diferenciación de los importes según la zona de entrega.

---

## 8. Persistencia y archivos generados

Durante la ejecución, el sistema utiliza los siguientes archivos:

| Archivo | Función |
|---|---|
| `appsettings.json` | Configuración de tarifas e impuestos |
| `idiomas.json` | Textos de la interfaz en español e inglés |
| `Facturacion.db` | Base de datos SQLite |
| Archivos `.csv` | Reportes de facturación exportados |

La base de datos se genera automáticamente cuando se inicia la aplicación, si todavía no existe.

Los archivos CSV se generan cuando el usuario selecciona la opción de exportación y especifica la ubicación de destino.

---

## 9. Consideraciones del sistema

- Los registros se procesan individualmente.
- Los datos incorrectos se muestran en el apartado de errores.
- Los paquetes se ordenan de mayor a menor importe total.
- Los códigos de paquetes duplicados no se incorporan nuevamente al historial.
- La información almacenada en SQLite permanece disponible al volver a iniciar la aplicación.
- Los cálculos financieros utilizan los parámetros definidos en el archivo de configuración.
- La interfaz puede cambiar de idioma sin reiniciar la aplicación.

---

## 10. Conclusión

El Sistema de Procesamiento y Auditoría de Facturación integra herramientas de procesamiento de datos, validación, programación orientada a objetos, estructuras de almacenamiento, cálculos financieros y persistencia de información.

Su implementación permite automatizar el cálculo de facturas de envío, identificar registros incorrectos, consultar el historial de paquetes y generar reportes para facilitar la revisión de las operaciones.

La separación de responsabilidades entre modelos, servicios, persistencia e interfaz gráfica permite mantener una estructura organizada y facilitar el mantenimiento y la evolución del sistema.

---

**Mini Proyecto 2 — Sistema de Procesamiento y Auditoría de Facturación**

Desarrollado con C# · .NET 10 · Windows Forms · SQLite
