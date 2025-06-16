using EspacioCalculadora; // Importamos el espacio de nombres de nuestra calculadora

internal class Program1
{
    private static void Main(string[] args)
    {
        Calculadora miCalculadora = new Calculadora();
        string? operacion;
        double numero;
        bool continuar = true;

        Console.WriteLine("¡Bienvenido a la Calculadora!");
        Console.WriteLine("Comandos disponibles: +, -, *, /, limpiar, salir");

        while (continuar)
        {
            Console.WriteLine($"Resultado actual: {miCalculadora.resultado}");
            Console.Write("Ingrese la operación o comando: ");
            operacion = Console.ReadLine()?.ToLower(); // Lee la entrada y la convierte a minúsculas

            switch (operacion)
            {
                case "+":
                    Console.Write("Ingrese el número a sumar: ");
                    if (double.TryParse(Console.ReadLine(), out numero))
                    {
                        miCalculadora.Sumar(numero);
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                    }
                    break;
                case "-":
                    Console.Write("Ingrese el número a restar: ");
                    if (double.TryParse(Console.ReadLine(), out numero))
                    {
                        miCalculadora.Restar(numero);
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                    }
                    break;
                case "*":
                    Console.Write("Ingrese el número a multiplicar: ");
                    if (double.TryParse(Console.ReadLine(), out numero))
                    {
                        miCalculadora.Multiplicar(numero);
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                    }
                    break;
                case "/":
                    Console.Write("Ingrese el número a dividir: ");
                    if (double.TryParse(Console.ReadLine(), out numero))
                    {
                        miCalculadora.Dividir(numero);
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                    }
                    break;
                case "limpiar":
                    miCalculadora.Limpiar();
                    Console.WriteLine("Calculadora limpiada. Resultado reiniciado a 0.");
                    break;
                case "salir":
                    continuar = false;
                    Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Comando no reconocido. Intente nuevamente.");
                    break;
            }
            Console.WriteLine(); // Salto de línea para mejor legibilidad
        }
    }
}