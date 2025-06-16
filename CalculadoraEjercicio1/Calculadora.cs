namespace EspacioCalculadora
{
    public class Calculadora // en calculadora y (ctrl .) genero constructor
    {
        private double dato;

        // constructor Vacio. siempre existe por mas que no lo ponga. 
        public Calculadora()
        {
            dato = 0;// lo inicilizo en cero.
        }

        // propiedades => devolver valores de los atributos privados.

        public double resultado
        {
            get
            {
                return dato;
            }
        }

        public void Sumar(double termino) // clase
        {
            dato = dato + termino; // dato+=termino
        }

        public void Restar(double termino)
        {
            dato = dato - termino;
        }

        public void Multiplicar(double termino)
        {
            dato = dato * termino;
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato = dato / termino;
            }
            else
            {
                dato = -99999;

            }


        }
         public void Limpiar() // limpia la variable dato en cero
            {
                dato = 0;
            }

    }
}
/*Ejercicio 1 
Dentro de su repositorio cree una carpeta llamada “Calculadora” y dentro de ella cree 
un nuevo proyecto de consola de .NET usando la instrucción "dotnet new console" .. 
Dentro de este proyecto, crear un nuevo archivo llamado Calculadora.cs y defina un 
espacio de nombres al comienzo del archivo (ej. namespace EspacioCalculadora; 
en la línea 1 del archivo) . Cree la clase Calculadora que permita encadenar 
operaciones sobre un mismo resultado guardado en un campo llamado dato, utilizando 
los siguientes métodos. 
● void Sumar(double termino) 
● void Restar(double termino) 
● void Multiplicar(double termino) 
● void Dividir(double termino) 
● void Limpiar() 
Cree también una propiedad llamada Resultado para obtener el valor del atributo 
dato. (Es decir solo defina el get). 
Para utilizar esta clase desde Program.cs, no olvide incorporar al mismo el espacio de 
nombres definido en el archivo Calculadora.cs, utilizando la palabra reservada using. 
Realice una interfaz de usuario para operar la calculadora que permita continuar 
solicitando operaciones hasta que el usuario ingrese un comando de escape. */