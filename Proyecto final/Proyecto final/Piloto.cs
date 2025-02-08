namespace Proyecto_final
{
    internal class Piloto : Persona
    {
        private int _noempleado;
        private string _aerolinea_asignada;
        private int _aniodeexperiencia;

        public Piloto()
        {
        }

        public Piloto(int noempleado, string aerolinea_asignada, int aniodeexperiencia, string nombre, string apellido, int edad, string correo, string direccion, 
            string identidad) :base (nombre, apellido, edad, correo, direccion, identidad)
        {
            _noempleado = noempleado;
            _aerolinea_asignada = aerolinea_asignada;
            _aniodeexperiencia = aniodeexperiencia;
        }

        public int Noempleado { get => _noempleado; set => _noempleado = value; }
        public string Aerolinea_asignada { get => _aerolinea_asignada; set => _aerolinea_asignada = value; }
        public int Aniodeexperiencia { get => _aniodeexperiencia; set => _aniodeexperiencia = value; }

        public override string ToString()
        {
            return base.ToString + $"Numero de empleado: {this.Noempleado}, Aerolinea aignada: {this.Aerolinea_asignada}, Año de experiencia: {this.Aniodeexperiencia}";
        }
    }
}
