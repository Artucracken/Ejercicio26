using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Becario: Empleados, Estudiante
    {
        protected string carrera;
        protected string curso;
        protected string departamento;
        protected double[] notaExamenes = new double[3];
        public Becario() : base()
        {

        }
        public Becario(string nombre, string apellidos, string dni, double sueldoBase): base (nombre,apellidos,dni,sueldoBase)
        {
            base.nombre = nombre;
            base.apellidos = apellidos;
            base.dni = dni;
            base.sueldoBase = sueldoBase;
        }

       

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }


        //Estos métodos solo se nombran a la hora de la creación del programa pero no dice nada a la hora de mostrarlos
        public double [] examenes()
        {
            /*Devolverá una lista con 3 notas del estudiante, a partir de las cuales se calculará la nota media*/
            
           notaExamenes[0] = 5.6;
            notaExamenes[1] = 4;
            notaExamenes[2] = 6.1;
            return notaExamenes;
        }

        public override string informacion()
        {
            return "Carrera:" + carrera + "\n"+ " Departamento: " + departamento;
;
        }

        public string notaMedia()
        {
            /*Calcula la media numérica(con un decimal) de las 3 notas que disponemos del alumno.*/
            double notaMedia = 0;
            double suma = 0;
            double[] notas = examenes();
            for (int i=0; i<notaExamenes.Length; i++)
            {
                suma = suma +notas[i];
            }
            notaMedia = suma / 3;
            return "La nota media del becario es: " + notaMedia;
        }

        public string universidad()
        {
           
            string universidad = "Oxford";
            return universidad; 
        }

        public string dameNombre()
        {
            return "Nombre:" + base.nombre + " " + base.apellidos;
        }
        public string dameDni()
        {
            return "DNI: " +  base.dni;
        }
        public string dameSueldo()
        {
            return "Sueldo: " + base.sueldoBase;
        }

    }
}
