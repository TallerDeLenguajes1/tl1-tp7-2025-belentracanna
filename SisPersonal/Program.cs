// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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