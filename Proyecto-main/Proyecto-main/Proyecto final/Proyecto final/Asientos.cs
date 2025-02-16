namespace Proyecto_final
{
    internal class Asientos
    {
        private string _clase;
        private int _id_asiento;
        private string _no_asientos;

        public Asientos()
        {
        }

        public string Clase { get => _clase; set => _clase = value; }
        public int Id_asiento { get => _id_asiento; set => _id_asiento = value; }
        public string No_asientos { get => _no_asientos; set => _no_asientos = value; }

        public Asientos(string clase, int id_asiento, string no_asientos)
        {
            Clase = clase;
            Id_asiento = id_asiento;
            No_asientos = no_asientos;
        }

        public override string ToString()
        {
            return $"Clase: {this.Clase}, ID del asiento: {this.Id_asiento}, Numero del asiento: {this.No_asientos}";
        }
    }
}
