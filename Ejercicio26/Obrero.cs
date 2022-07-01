namespace Ejercicio26
{
    class Obrero: Empleados
    {

        public Obrero(string nombre, string apellidos, string dni, double sueldoBase) : base(nombre, apellidos, dni, sueldoBase)
        {
            base.nombre = nombre;
            base.apellidos = apellidos;
            base.dni = dni;
            base.sueldoBase = sueldoBase;
        }
        public Obrero():base()
        {

        }
        protected string destinoTrabajo;
        protected double horasExtra;
        protected double precioHE;

        public double HorasExtra
        {
            get { return horasExtra; }
            set { horasExtra = value; }
        }
        public double PrecioHE
        {
            get { return precioHE; }
            set { precioHE = value; }
        }
        public string DestinoTrabajo
        {
            get { return destinoTrabajo; }
            set { destinoTrabajo = value; }
        }


        public override string informacion()
        {
            return  "Destino: " + destinoTrabajo +"\n"+ " Precio Horas Extra: "+ precioHE +"€";
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
    }
}
