using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class JefeDepartamento: Cualificados
    {
        public JefeDepartamento (string nombre, string apellidos, string dni, double sueldoBase): base (nombre, apellidos, dni, sueldoBase)
        {
            base.nombre = nombre;
            base.apellidos = apellidos;
            base.dni = dni;
            base.sueldoBase = sueldoBase;
        }
    protected string totalTrabaCargo;
        protected string proyectos;
        protected double plus;
    }
}
