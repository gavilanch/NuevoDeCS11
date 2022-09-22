// Ejemplo 1: Raw string literals

// Antes de C# 11

using DemoCS11;
using System.Numerics;
using System.Text;

var nombre = "Felipe";

var stringDeVariasLineas_AntesDeCS11 = 
                                        @$"Hola,

                                    mi nombre es ""{nombre}"".
                                      Esta línea está identada.";

//Console.WriteLine(stringDeVariasLineas_AntesDeCS11);

var stringDeVariasLineas_ConCS11 = $$""""
                                        Hola,
    
                                        mi nombre es "{{{nombre}}}".
                                            Esta """línea""" está identada.
                                        """";

//Console.WriteLine("--");

//Console.WriteLine(stringDeVariasLineas_ConCS11);

// Ejemplo 2: Líneas en interpolación de strings

var temperatura = 27;

string mensaje = $"La sensación humana a la temperatura {temperatura} es {
    temperatura switch
{
    > 45 => "Muerte",
    > 35 => "Demasiado calor",
    > 25 => "Agradable",
    > -10 => "Frío",
    <= -10 => "Muerte"
}}";

//Console.WriteLine(mensaje);

// Ejemplo 3: Strings literal utf-8

var utf8AntesDeCS11 = Encoding.UTF8.GetBytes("hola");

var utf8EnCS11 = "hola"u8.ToArray();

// Ejemplo 4: Patrones de listas

int[] numeros = { 1, 2, 1 };
var numerosString = ArregloAString(numeros);

var seEmparejan = numeros is [1, 2, 3];
var seEmparejan2 = numeros is [1, 2];
var seEmparejan3 = numeros is [1, 2, _];
var seEmparejan4 = numeros is [1, 2, >2];

//Console.WriteLine($"{numerosString} is [1, 2, 3]: " + seEmparejan);
//Console.WriteLine($"{numerosString} is [1, 2]: " + seEmparejan2);
//Console.WriteLine($"{numerosString} is [1, 2, _]: " + seEmparejan3);
//Console.WriteLine($"{numerosString} is [1, 2, >2]: " + seEmparejan4);

string ArregloAString(int[] arreglo)
{
    StringBuilder sb = new StringBuilder();
    sb.Append("[");
    for (int i = 0; i < arreglo.Length; i++)
    {
        var item = arreglo[i];
        if (i + 1 == arreglo.Length)
        {
            sb.Append($"{item}");
        }
        else
        {
            sb.Append($"{item},");
        }
    }
    sb.Append("]");
    return sb.ToString();
}

// Ejemplo 5: Miembros requeridos

//var persona = new Persona();

var persona2 = new Persona("Felipe");

var persona3 = new Persona()
{
    Nombre = "Felipe"
};

// Ejemplo 6: Alcance file

//var utilidades = new UtilidadesPersona();

var valor = persona2.ObtenerValor();

// Ejemplo 9: Matemática genérica

int[] numerosEnteros = { 1, 2, 3 };

Complex[] numerosComplejos = { new Complex(2, 3), new Complex(4, 1) };

var resultadoNumerosEnteros = MatematicaGenerica.Sumar<int, int>(numerosEnteros);
Console.WriteLine("La suma de 1, 2 y 3 es " + resultadoNumerosEnteros);

var resultadoNumerosComplejos = MatematicaGenerica.Sumar<Complex, Complex>(numerosComplejos);
Console.WriteLine("La suma de 2+3i + 4+i es " + resultadoNumerosComplejos);