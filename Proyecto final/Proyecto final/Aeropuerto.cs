namespace Proyecto_final
{
    internal class Aeropuerto
    {
        private string _nombre_aeropuerto;
        private int _id;

        public Aeropuerto()
        {
        }

        public Aeropuerto(string nombre, int id)
        {
            _nombre_aeropuerto = nombre;
            _id = id;
        }

        public string NombreAeropuerto { get => _nombre_aeropuerto; set => _nombre_aeropuerto = value; }
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return $"Nombre del aeropuerto: {this.NombreAeropuerto}, ID del aeropuerto: {this.Id}";
        }
    }
}
