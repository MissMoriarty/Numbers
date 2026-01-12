/*                                                
███  ██ ██  ██ ██▄  ▄██ ██████ █████▄  ▄████▄ ▄█████ 
██ ▀▄██ ██  ██ ██ ▀▀ ██ ██▄▄   ██▄▄██▄ ██  ██ ▀▀▀▄▄▄ 
██   ██ ▀████▀ ██    ██ ██▄▄▄▄ ██   ██ ▀████▀ █████▀ 
     

COLOCACIÓN DE LOS OPERADORES DE INCREMENTO Y DECREMENTO:

OPERADORES PREFIJOS:
  ++var;  --var;
  Primero se incrementa o decrementa el valor de la variable
  y luego se utiliza ese valor en la expresión.

OPERADORES SUFIJOS:
    var++;  var--;
    Primero se utiliza el valor actual de la variable en la expresión
    y luego se incrementa o decrementa su valor.
*/

int value = 1;
value++;
Console.WriteLine("First: " + value); //2
Console.WriteLine($"Second: {value++}"); //2
Console.WriteLine("Third: " + value); //3
Console.WriteLine("Fourth: " + (++value)); //4


/*TIPOS DE DATOS NUMÉRICOS:

Dividiremos los tipos numéricos en tres categorías:

Enteros (Integrales).
Punto Flotante (Científicos/Gráficos).
Decimal de alta precisión (Financieros).

-----------------------------------------------------------------------------

1. TIPOS DE DATOS ENTEROS (INTEGRALES):
Los tipos de datos enteros representan números sin componentes fraccionarios.
Pueden ser con signo (positivos y negativos) o sin signo (solo positivos).

byte: 8 bits,       sin signo,    rango: 0 a 255
sbyte: 8 bits,      con signo,    rango: -128 a 127
short: 16 bits,     con signo,    rango: -32,768 a 32,767
ushort: 16 bits,    sin signo,    rango: 0 a 65,535
int: 32 bits,       con signo,    rango: -2,147,483,648 a 2,147,483,647       ESTÁNDAR PARA CONTADORES Y BUCLES
uint: 32 bits,      sin signo,    rango: 0 a 4,294,967,295
long: 64 bits,      con signo,    rango: +-9,223,372,036,854,775,807          ID's BASES DE DATOS, CONTADORES GLOBALES
ulong: 64 bits,     sin signo,    rango: 0 a 18,446,744,073,709,551,615       CRIPTOGRAFÍA, GRANDES CONTADORES

-----------------------------------------------------------------------------
2. TIPOS DE DATOS DE PUNTO FLOTANTE (CIENTÍFICOS/GRÁFICOS):
Los tipos de datos de punto flotante representan números con componentes fraccionarios.

float: 32 bits,      con signo,    precisión: ~7 dígitos       GRÁFICOS 3D, JUEGOS
double: 64 bits,     con signo,    precisión: ~15-16 dígitos   CÁLCULOS CIENTÍFICOS, SIMULACIONES

-----------------------------------------------------------------------------

3. TIPOS DE DATOS DECIMALES DE ALTA PRECISIÓN (FINANCIEROS):
Los tipos de datos decimales de alta precisión están diseñados para aplicaciones que requieren una alta precisión decimal, como las aplicaciones financieras.
decimal: 128 bits,   con signo,    precisión: ~28-29 dígitos   APLICACIONES FINANCIERAS, DINERO
-----------------------------------------------------------------------------

SUFIJOS:
L o l,      tipo: long,      ejemplo: 1000L
U o u,      tipo: uint,      ejemplo: 1000U
UL,         tipo: ulong,     ejemplo: 1000UL
M o m,      tipo: decimal,   ejemplo: 19.99M
F o f,      tipo: float,     ejemplo: 3.14F

-----------------------------------------------------------------------------

MANEJO DE ERRORES O EXCEPCIONES:

OverflowException:
Se lanza cuando una operación aritmética produce un resultado que es muy grande para su tipo de datos.

Overflow en enteros:
Por defecto, C# no lanza error en overflow de enteros (int, long, short, byte, etc.), 
simplemente "da la vuelta" (wraps around). 
Para evitar esto, usa el bloque checked.
*/

int Max = int.MaxValue;
int Over = Max + 1; // Aquí NO lanzará excepción, simplemente "da la vuelta"
Console.WriteLine("Valor entero después de overflow sin checked: " + Over); // Valor negativo debido al wrap around

try
{
    checked
    {
        int max = int.MaxValue;
        int over = max + 1; // Aquí lanzará OverflowException
    }
}
catch (OverflowException ex)
{
    Console.WriteLine("¡El número es demasiado grande!");
}


/* Overflow en tipos decimales y de punto flotante:
A diferencia de los enteros, los tipos flotantes nunca lanzan excepciones por desbordamiento aritmético.
En su lugar, representan valores fuera de su rango como Infinity (Infinito).
*/

double limite = double.MaxValue;
double resultado = limite * 1.1;
Console.WriteLine("Valor de punto flotante después de overflow sin checked: " + resultado); // Imprime: ∞ (Infinity)

checked
    {
    double maxDouble = double.MaxValue;
    double overDouble = maxDouble * 2; // Aquí se volverá Infinity, no lanzará excepción
    if (double.IsInfinity(overDouble)) //Podemos verificar si es infinito
        Console.WriteLine("¡El número es demasiado grande y se ha convertido en Infinity!");
}


/*-----------------------------------------------------------------------------
UnderflowException:
Se lanza cuando una operación aritmética produce un resultado que es demasiado pequeño para ser representado por su tipo de dato.

Underflow en enteros:
Si restas 1 a MinValue , el valor salta a MaxValue (wraps around). 
Para evitar esto, usa el bloque checked.
*/
int Min = int.MinValue;
int Under = Min - 1; // Aquí NO lanzará excepción, simplemente "da la vuelta"
Console.WriteLine("Valor después de underflow sin checked: " + Under); // Valor positivo debido al wrap around

try
{
    checked
    {
        int min = int.MinValue;
        int under = min - 1; // Aquí lanzará OverflowException
    }
}
catch (OverflowException ex)
{
    Console.WriteLine("¡El número es demasiado pequeño!");
}

/* Underflow en tipos decimales y de punto flotante:
Si el número es tan pequeño (cercano a cero) que no puede ser representado, se convierte en 0.
*/

double peque = double.Epsilon; // El valor positivo más pequeño posible
double cero = peque / 1000;
Console.WriteLine("Valor después de underflow sin checked: " + cero); // Imprime: 0 (Sin excepción)

float pequeDec = float.Epsilon; // El valor positivo más pequeño posible
float ceroDec = pequeDec / 1000;
if(ceroDec == 0)
    Console.WriteLine("¡El número es demasiado pequeño y se ha convertido en 0!");


/*--------------------------------------------------------------------------------------

DIVISIÓN POR CERO

Enteros: Lanza la excepción: DivideByZeroException
Para evitar esto, usa el bloque checked.
*/

try
{
    checked
    {
        int dividendo = 13;
        int resultadoDiv = dividendo / 0; // Aquí lanzará DivideByZeroException
    }
}
catch (Exception ex)
{
    Console.WriteLine("¡No se puede dividir por cero!");
}

/*Punto flotante: No lanza excepción, el resultado es Infinity o NaN
Para evitar esto, verifica el divisor antes de la división o usa el bloque checekd.
*/

double x = 10.0;
double y = 0.0;
double z = x / y; // Resultado: Infinity (No rompe el programa)
if(double.IsInfinity(z) || double.IsNaN(z))
    Console.WriteLine("¡No se puede dividir por cero!");

/*-----------------------------------------------------------------------------------
FORMATO DE CADENAS (TO STRING):
Puedes usar especificadores de formato para controlar cómo se representan los números como cadenas.
*/

decimal precio = 1234.56m;
Console.WriteLine(precio.ToString()); // General: 1234.56
Console.WriteLine(precio.ToString("C")); // Currency: $1,234.56 (depende de la cultura local)
Console.WriteLine(precio.ToString("N1")); // Number: 1,234.6 (una cifra decimal y comas de miles, el decimal redondeado)
Console.WriteLine(precio.ToString("F1")); // Fixed: 1234.56 (sin comas de miles y un decimal)
Console.WriteLine(precio.ToString("N2")); // Number: 1,234.6 (dos decimales y comas de miles, el decimal redondeado)
Console.WriteLine(precio.ToString("F2")); // Fixed: 1234.56 (sin comas de miles y dos decimales)
double porcentaje = 0.543;
Console.WriteLine(porcentaje.ToString("P1")); // Percent: 54.3% (una cifra decimal)
Console.WriteLine(porcentaje.ToString("P2")); // Percent: 54.30% (dos cifras decimales)
DateTime date = DateTime.Now;
Console.WriteLine(date.ToString("dd/MM/yyyy")); // Fecha personalizada: 25/12/2023 (depende de la cultura local)
Console.WriteLine(date.ToString("ddd/ dd/MM/yyyy")); // Día de la semana abreviado: lun/ 25/12/2023
Console.WriteLine(date.ToString("dddd, dd MMMM yyyy")); // Día de la semana completo: lunes, 25 diciembre 2023

/*-----------------------------------------------------------------------------------
STRING.FORMAT:
Da más control sobre la construcción de cadenas complejas con múltiples valores formateados.
Usa llaves {} para insertar valores en posiciones específicas dentro de la cadena.
*/

double price = 49.99;
DateTime hoy = DateTime.Now;

string mensaje = String.Format("El precio es {0:C2} y la fecha es {1:dd-MM-yyyy}", price, hoy);
Console.WriteLine(mensaje);

/*-----------------------------------------------------------------------------------
INTERPOLACIÓN DE CADENAS:
Proporciona una forma más legible y concisa de construir cadenas con valores formateados
Es la más recomendada en C# moderno.
*/

double temperatura = 23.456;
DateTime fecha = DateTime.Now;

string texto = $"Temperatura: {temperatura:N1}°C - Fecha: {fecha:dddd, dd MMMM yyyy}"; 
Console.WriteLine(texto);

