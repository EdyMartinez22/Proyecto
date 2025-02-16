namespace Proyecto_final
{
    internal class Facturacion
    {
        private Boleto _boleto;
        private DateTime _fecha_facturacion;
        private int _id_factura;
        private Metodos_de_Pago _metodoPago;

        public Facturacion()
        {

        }

        public DateTime Fecha_facturacion { get => _fecha_facturacion; set => _fecha_facturacion = value; }
        public int Id_factura { get => _id_factura; set => _id_factura = value; }
        internal Boleto Boleto { get => _boleto; set => _boleto = value; }
        internal Metodos_de_Pago MetodoPago { get => _metodoPago; set => _metodoPago = value; }

        public Facturacion(DateTime fecha_facturacion, int id_factura, Boleto boleto, Metodos_de_Pago metodoPago)
        {
            Fecha_facturacion = fecha_facturacion;
            Id_factura = id_factura;
            Boleto = boleto;
            MetodoPago = metodoPago;
        }

        public override string ToString()
        {
            return $"Fecha de facturacion: {this.Fecha_facturacion}, ID de factura: {this.Id_factura}, Boleto: {this.Boleto}";
        }
    }
}
