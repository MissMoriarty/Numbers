
# Numbers - Guía de Tipos Numéricos en C#

Este proyecto es una aplicación de consola en **C# (.NET)** diseñada como una referencia práctica y educativa sobre el sistema de tipos numéricos, operadores aritméticos y formatos de cadena en el ecosistema .NET.

El código fuente incluye explicaciones detalladas en los comentarios y ejemplos ejecutables para cada concepto.

## Características y temas cubiertos

* **Operadores de Incremento y Decremento:** Diferencias entre prefijos (`++var`) y sufijos (`var++`).
* **Tipos de Datos:**
* **Integrales:** `byte`, `int`, `long`, etc., con sus rangos y usos recomendados (ej. contadores, bases de datos).
* **Punto Flotante:** `float` y `double` para gráficos y cálculos científicos.
* **Alta Precisión:** `decimal` para aplicaciones financieras.


* **Manejo de Excepciones:**
* Uso del bloque `checked` para detectar **Overflow** (desbordamiento) y **Underflow**.
* Comportamiento de tipos enteros vs. flotantes ante desbordamientos (Wrap around vs. Infinity).


* **Casos Especiales:**
* Manejo de **División por Cero** (`DivideByZeroException` vs. `Infinity`).
* Valores **NaN** (Not a Number).


* **Formato de Cadenas:**
* Uso de `ToString()` con especificadores (Moneda `C`, Porcentaje `P`, Fecha `dd/MM/yyyy`).
* `String.Format` y la moderna **Interpolación de cadenas** (`$"{var}"`).



## 🛠️ Tecnologías

* **Lenguaje:** C#
* **Framework:** .NET 10.0 (según configuración del proyecto)
* **Tipo de Proyecto:** Aplicación de Consola


## 💻 Instalación y Ejecución

1. **Clonar el repositorio:**
```bash
git clone https://github.com/tu-usuario/numbers.git

```


2. **Navegar al directorio del proyecto:**
```bash
cd numbers/numbers

```


3. **Ejecutar la aplicación:**
```bash
dotnet run

```



## 📄 Estructura del Código

* `Program.cs`: Contiene toda la lógica, ejemplos y documentación teórica en comentarios.
* `numbers.csproj`: Archivo de definición del proyecto .NET.

## 🤝 Contribución

Si encuentras algún error en los ejemplos o quieres agregar más casos de uso sobre tipos numéricos, ¡siéntete libre de abrir un Pull Request!

---

> **Nota:** Este proyecto sirve como una "hoja de trucos" (cheatsheet) interactiva para estudiantes y desarrolladores que deseen repasar los fundamentos numéricos en C#.
