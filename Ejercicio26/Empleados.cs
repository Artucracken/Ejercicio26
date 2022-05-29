using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    abstract class Empleados
    {
        protected string nombre;
        protected string apellidos;
        protected string dni;
        protected double sueldoBase;

        public Empleados()
        {

        }
        public Empleados(string nombre, string apellidos,string dni, double sueldoBase)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.sueldoBase = sueldoBase;
        }

        abstract public string informacion();
        
    }
}
