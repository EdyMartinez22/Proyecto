namespace Proyecto_final
{
    internal class Boleto
    {
        private Pasajero _pasajero;
        private Vuelos _vuelos;
        private Asientos _asientos;
        private double _pagos;

        public Boleto()
        {
        }

        public Boleto(Pasajero pasajero, Vuelos vuelos, Asientos asientos, double pagos)
        {
            _pasajero = pasajero;
            _vuelos = vuelos;
            _asientos = asientos;
            _pagos = pagos;
        }

        public double Pagos { get => _pagos; set => _pagos = value; }
        internal Pasajero Pasajero { get => _pasajero; set => _pasajero = value; }
        internal Vuelos Vuelos { get => _vuelos; set => _vuelos = value; }
        internal Asientos Asientos { get => _asientos; set => _asientos = value; }

        public override string ToString()
        {
            return $"Pagos: {this.Pagos}, Pasajero: {this.Pasajero}, Vuelos: {this.Vuelos}, Asientos: {this.Asientos}";
        }
    }
}
