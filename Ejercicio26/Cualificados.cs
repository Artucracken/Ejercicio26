using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Cualificados: Empleados
    {

        public Cualificados() : base()
        {

        }
        public Cualificados(string nombre, string apellidos, string dni, double sueldoBase) : base(nombre, apellidos, dni, sueldoBase)
        {
            base.nombre = nombre;
            base.apellidos = apellidos;
            base.dni = dni;
            base.sueldoBase = sueldoBase;
        }
        protected string titulacion;
        protected int plus;
        protected string departamento;

        public string Titulacion
        {
            get { return titulacion; }
            set { titulacion = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public int Plus
        {
            get { return plus; }
            set { plus = value; }
        }
        public string dameNombre()
        {
            return "Nombre: " + base.nombre + " " + base.apellidos;
        }
        public string dameDni()
        {
            return "DNI: " + base.dni;
        }
        public string dameSueldo()
        {
            return "Sueldo: " + base.sueldoBase;
        }
        public override string informacion()
        {
            return "Titulación: "+ titulacion + "\n" + " Departamento: " + departamento;
        }
    }
}
