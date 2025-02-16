namespace Proyecto_final
{
    internal class Puertas_de_abordaje
    {
        private int _numero_de_puerta;
        private Terminal _terminal;
        private string _aerolinea;

        public Puertas_de_abordaje()
        {

        }

        public int Numero_de_puerta { get => _numero_de_puerta; set => _numero_de_puerta = value; }
        public string Aerolinea { get => _aerolinea; set => _aerolinea = value; }
        internal Terminal Terminal { get => _terminal; set => _terminal = value; }

        public Puertas_de_abordaje(int numero_de_puerta, string aerolinea, Terminal terminal)
        {
            Numero_de_puerta = numero_de_puerta;
            Aerolinea = aerolinea;
            Terminal = terminal;
        }

        public override string ToString()
        {
            return $"Numero de puerta: {this.Numero_de_puerta}, Terminal: {this.Terminal}, Aerolinea: {this.Aerolinea}";
        }
    }
}
