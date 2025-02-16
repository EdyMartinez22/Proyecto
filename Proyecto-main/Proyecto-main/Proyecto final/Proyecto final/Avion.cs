namespace Proyecto_final
{
    internal class Avion
    {
        private int _capacidad;
        private Asientos _asientos;

        public Avion()
        {

        }

        public int Capacidad { get => _capacidad; set => _capacidad = value; }
        internal Asientos Asientos { get => _asientos; set => _asientos = value; }

        public Avion(int capacidad, Asientos asientos)
        {
            Capacidad = capacidad;
            Asientos = asientos;
        }

        public override string ToString()
        {
            return $"Capacidad: {this.Capacidad}, Asientos: {this.Asientos}";
        }
    }
}
