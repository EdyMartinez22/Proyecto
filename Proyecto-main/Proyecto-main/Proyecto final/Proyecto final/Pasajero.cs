namespace Proyecto_final
{
    internal class Pasajero : Persona
    {
        private int _codigo;
        private string _numero_pasajero;
        private int _numero_maleta;

        public Pasajero() 
        {

        }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Numero_pasajero { get => _numero_pasajero; set => _numero_pasajero = value; }
        public int Numero_maleta { get => _numero_maleta; set => _numero_maleta = value; }

        public Pasajero(int codigo, string numero_pasajero, int numero_maleta, string nombre, string apellido, int edad, string correo, string direccion, string identidad) : 
            base(nombre, apellido,  edad, correo, direccion, identidad)
            
        {
            Codigo = codigo;
            Numero_pasajero = numero_pasajero;
            Numero_maleta = numero_maleta;
        }

        public override string ToString()
        {
            return base.ToString + $"Codigo: {this.Codigo}, Numero de pasajero: {this.Numero_pasajero}, Numero de maleta: {this.Numero_maleta}";
        }
    }
}
