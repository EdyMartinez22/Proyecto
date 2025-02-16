namespace Proyecto_final
{
    internal class Vuelos
    {
        private int _id_vuelo;
        private DateTime _fecha_hora_salida;
        private DateTime _fecha_hora_llegada;
        private Avion _avion;
        private Puertas_de_abordaje _abordaje;
        private Tripulacion _tripulacion;
        private Piloto _piloto;
        private double _precio;

        public Vuelos()
        {

        }

        public int Id_vuelo { get => _id_vuelo; set => _id_vuelo = value; }
        public DateTime Fecha_hora_salida { get => _fecha_hora_salida; set => _fecha_hora_salida = value; }
        public DateTime Fecha_hora_llegada { get => _fecha_hora_llegada; set => _fecha_hora_llegada = value; }
        public double Precio { get => _precio; set => _precio = value; }
        internal Avion Avion { get => _avion; set => _avion = value; }
        internal Puertas_de_abordaje Abordaje { get => _abordaje; set => _abordaje = value; }
        internal Tripulacion Tripulacion { get => _tripulacion; set => _tripulacion = value; }
        internal Piloto Piloto { get => _piloto; set => _piloto = value; }

        public Vuelos(int id_vuelo, DateTime fecha_hora_salida, DateTime fecha_hora_llegada, double precio, Avion avion, Puertas_de_abordaje abordaje, Tripulacion tripulacion, Piloto piloto)
        {
            Id_vuelo = id_vuelo;
            Fecha_hora_salida = fecha_hora_salida;
            Fecha_hora_llegada = fecha_hora_llegada;
            Precio = precio;
            Avion = avion;
            Abordaje = abordaje;
            Tripulacion = tripulacion;
            Piloto = piloto;
        }

        public override string ToString()
        {
            return $"ID del vuelo: {this.Id_vuelo}, Fecha y hora de salida: {this.Fecha_hora_salida}, Fecha y hora de llegada: {this.Fecha_hora_llegada}, " +
                $"Precio: {this.Precio}, Avion: {this.Avion}, Puerta de abordaje: {this.Abordaje}, Tripulacion: {this.Tripulacion}, Piloto: {this.Piloto}";
        }
    }
}
