# 📦 FACTURACIÓN | Mini Proyecto 2

**Sistema de Procesamiento y Auditoría de Facturación — Logística y Entregas**

Proyecto académico correspondiente al **Mini Proyecto 2 de la materia de Programación**.

El objetivo es desarrollar una aplicación de escritorio utilizando **C# y Windows Forms (WinForms)**, capaz de procesar, validar y auditar facturas de una empresa de logística y envíos.

---

## 📌 Información general

Este repositorio será el espacio de trabajo colaborativo para el desarrollo del sistema, donde se almacenarán el código fuente, los recursos y la documentación del proyecto.

**Indicaciones para el equipo:**

- Leer cuidadosamente los requerimientos y las especificaciones.
- Desarrollar las funcionalidades correspondientes a cada integrante.
- Mantener una comunicación constante mediante el grupo del equipo.
- Reportar oportunamente cualquier error, inconveniente o duda.
- Registrar los avances y cambios realizados en el repositorio.
- Procurar que el código sea claro, organizado y fácil de mantener.

**Importante:** Cada integrante es responsable de cumplir con sus actividades y contribuir a la integración del sistema.

---

## 🎯 1. Descripción del proyecto

Una empresa regional de logística y envíos express necesita una aplicación de escritorio que permita gestionar las facturas de flete generadas diariamente en sus distintas sucursales.

Actualmente, los distribuidores registran lotes de paquetes mediante cadenas de texto que contienen información como:

`COD-101;Juan Perez;Zona A;15.5;200.0`

Cada registro contiene cinco campos:

| Campo | Descripción |
|---|---|
| Código | Identificador del paquete |
| Cliente | Nombre del cliente |
| Zona | Zona de entrega (A, B o C) |
| Peso | Peso del paquete en kilogramos |
| Valor declarado | Valor monetario del contenido |

El sistema deberá validar los registros recibidos, procesar sus datos y calcular los importes correspondientes.

Asimismo, contará con herramientas de auditoría, almacenamiento, exportación de reportes y configuración de tarifas.

### Objetivo general

Desarrollar una aplicación robusta, intuitiva y funcional que automatice el procesamiento de facturas, reduzca los errores de captura y facilite la consulta y auditoría de los envíos.

---

## ⚙️ 2. Requisitos funcionales

### RF1. Carga y configuración mediante JSON

Al iniciar, la aplicación deberá leer un archivo local denominado `appsettings.json`, que contendrá los parámetros principales del sistema:

- Precio base por kilogramo.
- Tasa de impuesto (IVA).
- Costo fijo de envío.

Si el archivo no existe o presenta errores, el sistema deberá informar al usuario mediante un mensaje claro.

### RF2. Interfaz multidioma

La aplicación permitirá cambiar dinámicamente entre dos idiomas:

- 🇲🇽 Español
- 🇺🇸 Inglés

El cambio se realizará mediante un control `ComboBox` y deberá actualizar inmediatamente los textos visibles de la interfaz, incluyendo botones, etiquetas, encabezados de tablas y mensajes emergentes (`MessageBox`).

### RF3. Captura y validación de lotes

El usuario podrá introducir o pegar múltiples registros en un campo de texto multilínea.

El sistema deberá:

- Separar y analizar cada registro.
- Eliminar espacios innecesarios.
- Detectar líneas vacías.
- Validar la estructura de los campos.
- Comprobar que los valores numéricos sean válidos.
- Identificar registros incorrectos sin detener el procesamiento.

### RF4. Procesamiento y cálculo financiero

Los paquetes validados deberán almacenarse temporalmente en arreglos de objetos.

Mediante estructuras de control de flujo, se calcularán:

- Subtotal correspondiente al peso.
- Recargos según la zona de entrega.
- Penalizaciones por exceso de peso.
- Seguro obligatorio, cuando corresponda.
- Impuestos aplicables.
- Total individual por paquete.
- Total general del lote.

Posteriormente, la información deberá almacenarse en una base de datos para mantener la persistencia de los registros.

### RF5. Auditoría e inspección visual

La interfaz incluirá un control `DataGridView` para visualizar los paquetes procesados.

Al seleccionar una fila, se mostrará un panel lateral con la información detallada del paquete, incluyendo sus metadatos y desglose financiero.

### RF6. Exportación de reportes CSV

El usuario podrá exportar los resultados del procesamiento a un archivo `.csv` delimitado por comas.

La ubicación del archivo se seleccionará mediante un control `SaveFileDialog`.

El sistema deberá manejar errores relacionados con rutas inválidas, permisos y acceso a archivos.

---

## 🧩 3. Conceptos de programación obligatorios

Durante el desarrollo será necesario implementar correctamente los siguientes conceptos:

| Concepto | Implementación requerida |
|---|---|
| Arreglos | Almacenamiento y manipulación mediante arreglos nativos |
| Cadenas | División, limpieza, inspección y transformación de texto |
| Control de flujo | Condicionales, selección múltiple y ciclos |
| Excepciones | Manejo de errores de formato, cálculos y archivos |
| POO | Clases, objetos, encapsulamiento y responsabilidades |
| Eventos | Interacción mediante eventos de controles WinForms |
| Persistencia | Lectura y escritura de archivos y bases de datos |

### Consideraciones importantes

**Arreglos:** Se deberá utilizar al menos una estructura nativa, como `Paquete[]` o `string[,]`. No se permite resolver todo el procesamiento únicamente mediante controles visuales o colecciones sin utilizar arreglos.

**Cadenas:** Implementar operaciones como `Split()`, `Trim()`, `ToUpper()` y `Replace()` cuando corresponda.

**Control de flujo:** Utilizar explícitamente estructuras `if`, `else`, `switch`, `for` y `while`, según las necesidades del algoritmo.

**Excepciones:** Incorporar bloques `try-catch` para controlar errores y evitar cierres inesperados.

**Programación orientada a objetos:** Crear al menos una clase que represente los paquetes o facturas y otra clase independiente para realizar los cálculos financieros.

**Eventos:** Implementar los eventos necesarios para botones, cambios de idioma y selección de registros.

---

## 🏗️ 4. Arquitectura y tecnologías

### Tecnologías requeridas

| Tecnología | Propósito |
|---|---|
| C# | Lenguaje de programación principal |
| .NET | Plataforma de desarrollo |
| Windows Forms | Interfaz gráfica de escritorio |
| JSON | Configuración de parámetros |
| CSV | Exportación de reportes |
| Base de datos | Persistencia de transacciones |
| Git y GitHub | Control de versiones y colaboración |

### Organización por capas

El sistema deberá seguir una arquitectura que separe las responsabilidades:

**1. Capa de presentación (UI)**

Responsable de la interacción con el usuario, formularios WinForms y manejo de eventos.

**2. Capa de dominio**

Contendrá los modelos y las clases que representen las entidades del sistema, como paquetes, facturas y sus datos.

**3. Capa de servicios**

Encargada de implementar las reglas de negocio, validación de cadenas, procesamiento de arreglos y cálculos financieros.

**4. Capa de persistencia**

Responsable de la lectura y escritura de información mediante archivos JSON, reportes CSV y base de datos.

### Estándares de codificación

Se seguirán las convenciones de nombres de Microsoft:

| Elemento | Convención | Ejemplo |
|---|---|---|
| Clases | PascalCase | `Paquete` |
| Métodos | PascalCase | `CalcularTotal()` |
| Propiedades | PascalCase | `Peso` |
| Variables locales | camelCase | `precioBase` |
| Campos privados | _camelCase | `_totalFactura` |

La interfaz gráfica no deberá contener directamente la lógica de cálculos financieros ni el procesamiento de archivos.

---

## 🧠 5. Retos de lógica de programación

Se deberán resolver tres retos principales relacionados con las necesidades del sistema.

### Reto 1. Sanitización y validación de texto

**Objetivo:** Procesar un lote de registros y detectar errores sin interrumpir la ejecución.

Ejemplos de entrada:

| Registro | Resultado |
|---|---|
| `PACK-001;Juan Perez;Zona A;12.5;150.0` | Válido |
| `PACK-002;Maria Lopez;Zona C;-5.0;200.0` | Inválido: peso negativo |
| `PACK-003;Pedro Gomez;Zona B;ABC;100.0` | Inválido: formato numérico |

**Actividades por desarrollar:**

1. Recorrer la cadena de entrada línea por línea.
2. Separar los campos utilizando el delimitador `;`.
3. Limpiar los espacios sobrantes.
4. Validar los valores y tipos de datos.
5. Guardar los paquetes correctos en un arreglo.
6. Registrar las líneas incorrectas en un arreglo paralelo de errores.
7. Continuar procesando los demás registros aunque existan errores.

**Resultado esperado:** Un conjunto de paquetes válidos y un registro de errores que permita identificar los datos rechazados.

### Reto 2. Redimensionamiento y ordenamiento de arreglos

**Objetivo:** Implementar manualmente la administración de arreglos tradicionales.

El almacenamiento inicial tendrá una capacidad fija de cinco paquetes:

`Paquete[] arregloBase = new Paquete[5];`

**Actividades por desarrollar:**

1. Crear un arreglo inicial de tamaño fijo.
2. Insertar los paquetes validados.
3. Detectar cuándo el arreglo alcanza su capacidad máxima.
4. Crear un nuevo arreglo con el doble de capacidad.
5. Copiar los elementos anteriores uno por uno.
6. Continuar incorporando nuevos paquetes.
7. Ordenar los paquetes de mayor a menor costo total.

Para el ordenamiento se deberá utilizar un algoritmo de comparación, como:

- Método burbuja.
- Método de selección.

**Resultado esperado:** Un arreglo capaz de ampliar manualmente su capacidad y mostrar los paquetes ordenados por su importe total.

### Reto 3. Impuestos escalonados y tarifas regionales

**Objetivo:** Calcular el costo final de cada envío aplicando distintas reglas de negocio.

#### Recargos por zona

| Zona | Recargo sobre subtotal |
|---|---:|
| Zona A | 5% |
| Zona B | 10% |
| Zona C | 18% |

#### Penalización por exceso de peso

Cuando el paquete supere los **20 kg**, cada kilogramo adicional generará un cargo equivalente al 25% del precio base por kilogramo configurado en JSON.

#### Seguro obligatorio

Cuando el valor declarado del paquete sea superior a **$1,000.00**, se agregará un seguro equivalente al 2% del valor declarado.

#### Consideraciones del cálculo

El algoritmo deberá contemplar:

- Precio base obtenido desde JSON.
- Peso total del paquete.
- Zona de entrega.
- Penalización por peso adicional.
- Seguro por valor declarado.
- Costo fijo de envío.
- Impuesto correspondiente.

**Resultado esperado:** Un desglose financiero preciso de cada paquete y el total del lote, aplicando correctamente las reglas del negocio.

---

## 🛡️ 6. Validaciones y manejo de errores

La aplicación deberá ser resistente a errores de entrada y ejecución.

Se contemplarán situaciones como:

- Archivos JSON inexistentes o incorrectos.
- Rutas de archivo inválidas.
- Problemas de permisos de lectura o escritura.
- Valores numéricos incorrectos.
- Campos vacíos o registros incompletos.
- Pesos negativos.
- Zonas de entrega no reconocidas.
- Errores durante los cálculos financieros.

En todos los casos, se deberán mostrar mensajes comprensibles para el operador, sin interrumpir innecesariamente el funcionamiento de la aplicación.

---

## 🤝 7. Trabajo colaborativo y repositorio

El proyecto deberá desarrollarse utilizando una plataforma de forja de software, como **GitHub**, para facilitar el trabajo en equipo y el seguimiento de los avances.

### Recomendaciones de colaboración

1. Mantener actualizado el repositorio.
2. Trabajar en las funcionalidades asignadas.
3. Utilizar nombres descriptivos para archivos, clases y métodos.
4. Realizar commits con mensajes claros.
5. Evitar modificar el trabajo de otros integrantes sin coordinación.
6. Revisar el funcionamiento del sistema antes de integrar cambios.
7. Comunicar cualquier problema que afecte el desarrollo del proyecto.

**Nota para el equipo:** La comunicación y organización son fundamentales. Cualquier duda, ajuste o inconveniente deberá comentarse en el grupo para mantener una integración ordenada.

---

## 📁 8. Entregables del proyecto

Los entregables deberán presentarse **por separado**, utilizando los formatos correspondientes (`.zip`, `.doc`, `.docx` o `.pdf`, según aplique).

### Entregable 1. Respaldo del repositorio

Archivo que contenga el proyecto completo, incluyendo su código fuente y los recursos necesarios.

### Entregable 2. Instalación del programa

Archivo o paquete con todos los elementos necesarios para instalar y ejecutar la aplicación.

### Entregable 3. Documentación del sistema

Se deberá elaborar documentación de usuario y documentación técnica.

**Documentación de usuario:**

- Explicación general de la aplicación.
- Instrucciones de uso.
- Descripción de las funcionalidades.
- Ejemplos del procesamiento de facturas.

**Documentación técnica:**

- Requisitos de instalación.
- Arquitectura del sistema.
- Estructura general del proyecto.
- Configuración y mantenimiento.
- Instrucciones para clonar el repositorio.
- Enlaces necesarios para acceder al código fuente.

### Entregable 4. Video de presentación

Video demostrativo del sistema funcionando.

- Duración máxima: **5 minutos**.
- Mostrar las principales funcionalidades.
- Demostrar el procesamiento y la auditoría de facturas.

Si el archivo supera el límite permitido en el aula virtual, se entregará un PDF que contenga el enlace para visualizar o descargar el video.

### Entregable 5. Reporte de participación

Documento que especifique las contribuciones de cada integrante del equipo.

Deberá incluir:

| Información | Descripción |
|---|---|
| Nombre | Nombre completo del estudiante |
| ID | Identificador del alumno |
| Rol | Función desempeñada en el equipo |
| Participación | Actividades y componentes desarrollados |

El reporte deberá reflejar de manera clara las responsabilidades y aportaciones individuales.

---

## ✅ 9. Lista de verificación final

Antes de realizar la entrega, comprobar que:

- [ ] La aplicación inicia correctamente.
- [ ] La configuración JSON se carga y valida.
- [ ] El cambio de idioma funciona dinámicamente.
- [ ] Los lotes se procesan sin interrupciones.
- [ ] Se identifican y reportan registros incorrectos.
- [ ] Los arreglos se redimensionan y ordenan correctamente.
- [ ] Los cálculos financieros aplican las reglas establecidas.
- [ ] El DataGridView muestra los registros procesados.
- [ ] El panel de inspección presenta los detalles correctos.
- [ ] Los reportes CSV se exportan correctamente.
- [ ] La base de datos permite almacenar la información requerida.
- [ ] Los errores se controlan mediante excepciones.
- [ ] La documentación está completa.
- [ ] Todos los entregables están preparados.

---

## 📝 Consideraciones finales

El propósito del proyecto no es únicamente obtener una aplicación funcional, sino demostrar el uso adecuado de los conceptos de programación, la organización del código y el desarrollo colaborativo de software.

Se espera que cada integrante participe activamente, cumpla con sus responsabilidades y contribuya a mantener la calidad del proyecto.

**El éxito del desarrollo dependerá de una buena comunicación, una implementación organizada y el compromiso de todo el equipo.**

---

**Mini Proyecto 2 | Sistema de Procesamiento y Auditoría de Facturación**

*Desarrollado con C# · .NET · Windows Forms · GitHub*
