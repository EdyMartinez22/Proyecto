namespace Proyecto_final
{
    internal class Tripulacion : Persona
    {
        private int _codigo_empleado;
        private string _cargo;

        public Tripulacion()
        {
        }

        public Tripulacion(int codigo_empleado, string cargo, string nombre, string apellido, int edad, string correo, string direccion, 
            string identidad) :base(nombre, apellido, edad, correo, direccion, identidad)
        {
            _codigo_empleado = codigo_empleado;
            _cargo = cargo;
        }

        public int Codigo_empleado { get => _codigo_empleado; set => _codigo_empleado = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }

        public override string ToString()
        {
            return $"Codigo de empleado: {this.Codigo_empleado}, Cargo {this.Cargo}" + base.ToString();
        }
    }
}
