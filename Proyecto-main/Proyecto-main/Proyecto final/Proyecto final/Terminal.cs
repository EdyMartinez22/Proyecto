namespace Proyecto_final
{
    internal class Terminal
    {
        private int _codigo_edificio;
        private string _Nombre_de_area;
        private Aeropuerto _aeropuerto;

        public Terminal()
        {

        }

        public int Codigo_edificio { get => _codigo_edificio; set => _codigo_edificio = value; }
        public string Nombre_de_area { get => _Nombre_de_area; set => _Nombre_de_area = value; }
        internal Aeropuerto Aeropuerto { get => _aeropuerto; set => _aeropuerto = value; }

        public Terminal(int codigo_edificio, string nombre_de_area, Aeropuerto aeropuerto)
        {
            Codigo_edificio = codigo_edificio;
            Nombre_de_area = nombre_de_area;
            Aeropuerto = aeropuerto;
        }

        public override string ToString()
        {
            return $"Codigo del edificio: {this.Codigo_edificio}, Nombre del area: {this.Nombre_de_area}, Aeropuerto: {this.Aeropuerto}";
        }
    }
}
