namespace Proyecto_final
{
    internal class Tripulacion : Persona
    {
        private int _codigo_empleado;
        private string _cargo;

        public Tripulacion()
        {

        }

        public int Codigo_empleado { get => _codigo_empleado; set => _codigo_empleado = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }

        public Tripulacion(int codigo_empleado, string cargo, string nombre, string apellido, int edad, string correo, string direccion, string identidad) :
            base(nombre, apellido, edad, correo, direccion, identidad)
        {
            Codigo_empleado = codigo_empleado;
            Cargo = cargo;
        }

        public override string ToString()
        {
            return $"Codigo de empleado: {this.Codigo_empleado}, Cargo {this.Cargo}" + base.ToString();
        }
    }
}
