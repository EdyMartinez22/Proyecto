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

        public double Pagos { get => _pagos; set => _pagos = value; }
        internal Pasajero Pasajero { get => _pasajero; set => _pasajero = value; }
        internal Vuelos Vuelos { get => _vuelos; set => _vuelos = value; }
        internal Asientos Asientos { get => _asientos; set => _asientos = value; }

        public Boleto(double pagos, Pasajero pasajero, Vuelos vuelos, Asientos asientos)
        {
            Pagos = pagos;
            Pasajero = pasajero;
            Vuelos = vuelos;
            Asientos = asientos;
        }

        public override string ToString()
        {
            return $"Pagos: {this.Pagos}, Pasajero: {this.Pasajero}, Vuelos: {this.Vuelos}, Asientos: {this.Asientos}";
        }
    }
}
