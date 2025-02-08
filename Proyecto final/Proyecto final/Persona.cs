namespace Proyecto_final
{
    internal class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _correo;
        private string _direccion;
        private string _identidad;

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, int edad, string correo, string direccion, string identidad)
        {
            _nombre = nombre;
            _apellido = apellido;
            _edad = edad;
            _correo = correo;
            _direccion = direccion;
            _identidad = identidad;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Identidad { get => _identidad; set => _identidad = value; }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre}, Apellido: {this.Apellido}, Edad: {this.Edad}, Correo: {this.Correo}, Direccion: {this.Direccion}, Identidad: {this.Identidad}";
        }
    }
}
