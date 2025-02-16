namespace Proyecto_final
{
    internal class Aeropuerto
    {
        private string _nombre_aeropuerto;
        private int _id;

        public Aeropuerto()
        {
        }

        public string Nombre_aeropuerto { get => _nombre_aeropuerto; set => _nombre_aeropuerto = value; }
        public int Id { get => _id; set => _id = value; }

        public Aeropuerto(string nombre_aeropuerto, int id)
        {
            Nombre_aeropuerto = nombre_aeropuerto;
            Id = id;
        }

        public override string ToString()
        {
            return $"Nombre del aeropuerto: {this.Nombre_aeropuerto}, ID del aeropuerto: {this.Id}";
        }
    }
}
