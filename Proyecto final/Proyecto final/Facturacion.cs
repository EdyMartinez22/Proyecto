namespace Proyecto_final
{
    internal class Facturacion
    {
        private Boleto _boleto;
        private DateTime _fecha_facturacion;
        private int _id_factura;
        //private Metodosdepagos _metodosdepagos;

        public Facturacion()
        {
        }

        public Facturacion(Boleto boleto, DateTime fecha_facturacion, int id_factura)
        {
            _boleto = boleto;
            _fecha_facturacion = fecha_facturacion;
            _id_factura = id_factura;
        }

        public DateTime Fecha_facturacion { get => _fecha_facturacion; set => _fecha_facturacion = value; }
        public int Id_factura { get => _id_factura; set => _id_factura = value; }
        internal Boleto Boleto { get => _boleto; set => _boleto = value; }

        public override string ToString()
        {
            return $"Fecha de facturacion: {this.Fecha_facturacion}, ID de factura: {this.Id_factura}, Boleto: {this.Boleto}";
        }
    }
}
