using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Administracion
{
    // los enum ya tienen un numero enmascarado auxiliar = 1 , si no le pongo numero comienza en cero, como los arreglos
    public enum Cargo
    {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5
    }
    public class Empleado
    {
        private string nombre; // siempre los campos son privados 
        private string apellido;
        private DateTime fecha_nacimiento;
        private char estado_civil;
        private DateTime fecha_ingreso;
        private double sueldo_basico;
        private Cargo cargos;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; }
        public char Estado_civil { get => estado_civil; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; }
        public double Sueldo_basico { get => sueldo_basico; }
        public Cargo Cargos { get => cargos;  }

        // constructor vacio (situarme seleccionando todos los datos ( ctrl.) y me genera el constructor)
        //defino los parametros


        public Empleado(string nombre, string apellido, DateTime fecha_nacimiento, char estado_civil, DateTime fecha_ingreso, double sueldo_basico, Cargo cargos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
            this.estado_civil = estado_civil;
            this.fecha_ingreso = fecha_ingreso;
            this.sueldo_basico = sueldo_basico;
            this.cargos = cargos; 
        }// me genera todos los parametros
         // nombres de los metodos publicos empiezan por mayuscula
        public int Antiguedad() // metodo equivalente a una funcion
        {
            //fecha actual - fecha ingreso
            DateTime fecha_actual = DateTime.Now; // fecha actual con una propiedad get
            int antiguedad = fecha_actual.Year - fecha_ingreso.Year;

            if (fecha_actual.Month < fecha_ingreso.Month || fecha_actual.Month == fecha_ingreso.Month && fecha_actual.Day < fecha_ingreso.Day)
            {
                antiguedad--;// me reste un año
            }
            return antiguedad;

        }

        public int Edad()//metodo equivalente a una funcion
        {
            DateTime fecha_actual = DateTime.Now;// fecha actual con una propiedad get
            int edad = fecha_actual.Year - fecha_nacimiento.Year;
            if (fecha_actual.Month < fecha_nacimiento.Month || fecha_actual.Month == fecha_nacimiento.Month && fecha_actual.Day < fecha_actual.Day)
            {
                edad--;
            }
            return edad;
        }
        /*      public int AñosJubilacion()
                {
                    int edad = Edad();
                    int falta_para_jubilarme = 65 - edad;

                    return falta_para_jubilarme;
                }
        */

        public int AñosJubilacion()
        {
            return 65 - Edad(); // llamo a la funcion edad ya creada.
        }

        public double Salario()
        {
            double adicional = 0;
            if (Antiguedad() < 20)
            {
                adicional = sueldo_basico * Antiguedad() / 100;
            }
            else
            {
                adicional = sueldo_basico * 0.25;
            }
            if (cargos == Cargo.Ingeniero || cargos == Cargo.Especialista)
            {
                adicional = adicional * 0.50;
            }
            if (estado_civil == 'c' || estado_civil== 'C')
            {
                adicional = adicional + 150000;
            }
           

            return sueldo_basico + adicional;
        }
    }


        

    }
 