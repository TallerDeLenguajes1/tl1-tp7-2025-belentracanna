using System.Data;
using Administracion;

/*Ejercicio 2 
Dentro de su repositorio cree una carpeta llamada “SisPersonal”,y dentro de ella cree 
un nuevo proyecto de consola de .NET usando la instrucción "dotnet new console" 
realizaremos un pequeño sistema para administración del personal de una empresa. 
El mismo tiene que cumplir con los siguientes requisitos: 
1. Crear una clase Empleado para almacenar la siguiente información:  
a. Nombre (string),  
b. Apellido (string),  
c. Fecha de nacimiento (datetime),  
d. Estado civil (char), 
e. Fecha de ingreso en la empresa (datetime),  
f. 
Sueldo Básico (double),  
g. Cargo (cargos)  
Nota: Cargo es una variable de tipo “cargos” que es enumeración 
(enum) que ud debería definir con los siguientes elementos: Auxiliar
Administrativo;  Ingeniero; Especialista; Investigador. (investigue el uso 
de  enum en C# para realizar esto) 
2. Cree los métodos necesarios para poder obtener los datos que se detallan a 
continuación: 
a. Calcular lo siguiente: 
i. 
La antigüedad del empleado en la empresa.  
ii. 
iii. 
La edad del empleado, 
La cantidad de años que le falta al empleado para poder 
jubilarse, considerando que la edad de jubilación es de 65.  
b. Calcular el salario, de acuerdo a la fórmula: Salario = Sueldo Básico + 
Adicional. Para ello el Adicional contempla la antigüedad en años, el 
cargo y si es casado: 
i) 1 % del sueldo básico por cada año de antigüedad hasta los 
20 años, a partir de este, el porcentaje se fija en 25%. 
ii) Si el cargo es Ingeniero o Especialista, el Adicional se 
incrementa en un 50%. 
iii)   Si es casado al Adicional se le aumenta $150.000.  
Por ejemplo, si la antigüedad es de 15 años y el Sueldo Básico = 
$650.000, el Adicional es 65.0000 * 0.15 = 97.500. Si además el 
cargo es Ingeniero o Especialista, se incrementa el Adicional en 
un 50%. Esto es: 97.500* 1.50 = 146.250. Si a su vez es casado 
el Adicional será: 146.250+ 150.000= 296.250 
c. Cargue los datos para 3 empleados en un arreglo de tipo empleados. 
d. Obtener el Monto Total de lo que se paga en concepto de Salarios. 
e. Muestre por pantalla los datos del empleado que esté más próximo a 
jubilarse (incluyendo los datos del apartado 2.a y el salario 
correspondiente.  
NOTA: Los puntos a y b deben estar definidos dentro de la clase como 
propiedades o métodos según corresponda  
*/

internal class Program2
{
    private static void Main(string[] args)
    {
        double salario1, salario2, salario3, salario4;
        int añosJub1, añosJub2, añosJub3, añosJub4;


        Empleado empleado1 = new Empleado("Lucas", "Alvarez", new DateTime(1984, 05, 14), 's', new DateTime(2006, 12, 23), 1500000, Cargo.Ingeniero);

        Empleado empleado2 = new Empleado("Lucila", "Calez", new DateTime(1977, 08, 14), 'c', new DateTime(2000, 01, 01), 2500000, Cargo.Administrativo);

        Empleado empleado3 = new Empleado("Luz", "Gonzalez", new DateTime(1965, 08, 20), 'c', new DateTime(2010, 02, 01), 1200000, Cargo.Especialista);

        Empleado empleado4 = new Empleado("Maria", "Gomez", new DateTime(1945, 10, 04), 's', new DateTime(2024, 06, 01), 900000, Cargo.Investigador);


        salario1 = empleado1.Salario();
        Console.WriteLine("Concepto: salario1: || Monto: $" + salario1);
        salario2 = empleado2.Salario();
        Console.WriteLine("Concepto: salario2: || Monto: $ " + salario2);
        salario3 = empleado3.Salario();
        Console.WriteLine("Concepto: salario3: || Monto: $" + salario3);
        salario4 = empleado4.Salario();
        Console.WriteLine("Concepto: salario4: || Monto: $ " + salario4);


        double SalarioTotal = salario1 + salario2 + salario3 + salario4;

        Console.WriteLine("Concepto: Salario || Monto Total : $ " + SalarioTotal);


        añosJub1 = empleado1.AñosJubilacion();
        Console.WriteLine("Concepto: jubilacion: || años jubilacion: " + añosJub1);

        añosJub2 = empleado2.AñosJubilacion();
        Console.WriteLine("Concepto: jubilacion: || años jubilacion: " + añosJub2);

        añosJub3 = empleado3.AñosJubilacion();
        Console.WriteLine("Concepto: jubilacion: || años jubilacion: " + añosJub3);

        añosJub4 = empleado4.AñosJubilacion();
        Console.WriteLine("Concepto: jubilacion: || años jubilacion: " + añosJub4);

        if (añosJub1 <= añosJub2 && añosJub1 <= añosJub3 && añosJub1 <= añosJub4)
        {
            MostrarDatosEmpleado(empleado1);
        }
        else
        {
            if (añosJub2 <= añosJub1 && añosJub2 <= añosJub3 && añosJub2 <= añosJub4)
            {
                MostrarDatosEmpleado(empleado2);
            }
            else
            {
                if (añosJub3 <= añosJub1 && añosJub3 <= añosJub2 && añosJub3 <= añosJub4)
                {

                    MostrarDatosEmpleado(empleado3);
                }
                else
                {
                    MostrarDatosEmpleado(empleado4);
                }
            }

        }
    }
    // hacer una funcion fuera del mail como en c

    public static void MostrarDatosEmpleado(Empleado empleado)
    {
        Console.WriteLine("******Datos del Empleado ********");
        Console.WriteLine("Nombre: " + empleado.Nombre + "," + empleado.Apellido);
        Console.WriteLine(" Fecha de Nacimiento:" + empleado.Fecha_nacimiento.ToString("dd/MM/yyyy") + " || Edad : " + empleado.Edad());

        if (empleado.Estado_civil == 's')
        {
            Console.WriteLine("Estado Civil: Soltero");
        } else
        {
            Console.WriteLine("Estado Civil: Casado");
        }

        Console.WriteLine("Fecha de ingreso:" + empleado.Fecha_ingreso.ToString("dd/MM/yyyy"));
        Console.WriteLine("Antiguedad:" + empleado.Antiguedad());
        Console.WriteLine("Años restantes para jubilarte: " + empleado.AñosJubilacion());
        Console.WriteLine("Cargo:" + empleado.Cargos + " " + "basico $" + empleado.Sueldo_basico);
        Console.WriteLine(" salario: $" + empleado.Salario());
        Console.WriteLine("...................................................................");

    }
}