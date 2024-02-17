public class Program1
{
    static void Main()
    {
        int numeroEntero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa un número entero: ");

        decimal numeroDecimal = Convert.ToDecimal(numeroEntero);

        Console.WriteLine("El número decimal equivalente es: {numeroDecimal}");
    }
}
public class Program2
{
    static void Main()
    {
        decimal numeroDecimal = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingresa un número decimal: ");

        float numeroFlotante = Convert.ToSingle(numeroDecimal);

        Console.WriteLine("El número flotante equivalente es: {numeroFlotante}");
    }
}
public class Program3
{
    static void Main()
    {
        float numeroFlotante = Convert.ToSingle(Console.ReadLine());
        Console.Write("Ingresa un número flotante: ");

        int numeroEntero = Convert.ToInt32(numeroFlotante);


        Console.WriteLine("El número entero equivalente es: {numeroEntero}");
    }
}
public class Program4
{
    static void Main()
    {
        char caracter = Console.ReadKey().KeyChar;
        Console.Write("Ingresa un carácter: ");

        int valorEntero = caracter;

        Console.WriteLine("\nEl valor entero del carácter '{caracter}' es: {valorEntero}");
    }
}
public class Program5
{
    static void Main()
    {
        int numeroEntero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa un número entero (entre 0 y 127): ");

        if (numeroEntero >= 0 && numeroEntero <= 127)
        {
            char caracter = (char)numeroEntero;

            Console.WriteLine("El carácter ASCII correspondiente al número {numeroEntero} es: {caracter}");
        }
        else
        {
            Console.WriteLine("El número entero ingresado está fuera del rango permitido.");
        }
    }
}
public class Program6
{
        static void Main()
    {
        int numeroEntero = Convert.ToInt32(Console.ReadLine());
       
        Console.Write("Ingresa un número entero (entre 0 y 1024): ");

            if (numeroEntero >= 0 && numeroEntero <= 1024)
            {
                char caracter = (char)numeroEntero;

                Console.WriteLine("El carácter ASCII correspondiente al número {numeroEntero} es: {caracter}");
            }
            else
            {
                Console.WriteLine("El número entero ingresado está fuera del rango permitido.");
            }
        }
    }
public class Program7
{
        static void Main()
        {
            Console.Write("Ingresa el primer número decimal: ");
            double numero1 = double.Parse
            (Console.ReadLine());

            Console.Write("Ingresa el segundo número decimal: ");
            double numero2 = double.Parse(Console.ReadLine());

            double resta = numero1 - numero2;

            Console.WriteLine("La resta de " + numero1 + " y " + numero2 + " es: " + resta);
        }
    }
public class Program8
{
    static void Main()
    {
        Console.Write("Ingresa el primer número flotante: ");
        float numero1 = float.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número flotante: ");
        float numero2 = float.Parse(Console.ReadLine());

        float multiplicacion = numero1 * numero2;

        Console.WriteLine("La multiplicación de " + numero1 + " y " + numero2 + " es: " + multiplicacion);
    }
}
public class Program9
{
    static void Main()
    {
        Console.Write("Ingresa el dividendo (número a dividir): ");
        int dividendo = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el divisor (número por el cual se divide): ");
        int divisor = int.Parse(Console.ReadLine());
        int division = dividendo / divisor;

            Console.WriteLine("La división de " + dividendo + " entre " + divisor + " es: " + division);
     
    }
}
public class Program10
{
    static void Main()
    {
        Console.Write("Ingresa el dividendo (número a dividir): ");
        int dividendo = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el divisor (número por el cual se divide): ");
        int divisor = int.Parse(Console.ReadLine());

        int modulo = dividendo % divisor;

        Console.WriteLine("El módulo (resto de la división) de " + dividendo + " entre " + divisor + " es: " + modulo);
    }
}
public class Program11
{
    static void Main()
    {
        Console.Write("Ingresa una cadena de texto: ");
        string cadena = Console.ReadLine();

        string cadenaMayusculas = cadena.ToUpper();

        Console.WriteLine("La cadena en mayúsculas es: " + cadenaMayusculas);
    }
}
public class Program12
{
    static void Main()
    {
        Console.Write("Ingresa una cadena de texto: ");
        string cadena = Console.ReadLine();

        string cadenaMinusculas = cadena.ToLower();

        Console.WriteLine("La cadena en minúsculas es: " + cadenaMinusculas);
    }
}
public class Program13
{
    static void Main()
    {
        Console.Write("Ingresa una cadena de texto: ");
        string cadena = Console.ReadLine();

        char[] caracteres = cadena.ToCharArray();

        Array.Reverse(caracteres);

        string cadenaAlReves = new string(caracteres);

        Console.WriteLine("La cadena al revés es: " + cadenaAlReves);
    }
}
public class Program14
{
    static void Main()
    {
        Console.Write("Ingresa una cadena de texto: ");
        string cadena = Console.ReadLine();

        Console.Write("Ingresa la palabra que deseas buscar: ");
        string palabraABuscar = Console.ReadLine();

        if (cadena.Contains(palabraABuscar))
        {
            Console.WriteLine("La palabra '" + palabraABuscar + "' ha sido encontrada en la cadena.");
        }
        else
        {
            Console.WriteLine("La palabra '" + palabraABuscar + "' no ha sido encontrada en la cadena.");
        }
    }
}
public class Program15
{
    static void Main()
    {
        Console.Write("Ingresa una cadena de texto: ");
        string cadena = Console.ReadLine();

        cadena = cadena.ToLower();

        int contadorVocales = 0;

        foreach (char caracter in cadena)
        {
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                contadorVocales++;
            }
        }

        Console.WriteLine("El número de vocales en la cadena es: " + contadorVocales);
    }
}
public class Program16
{
    static void Main()
    {
        Console.Write("Ingresa la longitud de la base del triángulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.Write("Ingresa la altura del triángulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

        Console.WriteLine("El área del triángulo es: " + areaTriangulo);
    }
}
public class Program17
{
    static void Main()
    {
        Console.Write("Ingresa el radio de la esfera: ");
        double radio = double.Parse(Console.ReadLine());

        double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);

        Console.WriteLine("El volumen de la esfera es: " + volumen);
    }
}
public class Program19
{
    static void Main()
    {
        Console.Write("Ingresa la temperatura en grados Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);
    }
}
public class Program20
{
    static void Main()
    {
        Console.Write("Ingresa la temperatura en grados Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (5.0 / 9.0) * (fahrenheit - 32);

        Console.WriteLine("La temperatura en grados Celsius es: " + celsius);
    }
}