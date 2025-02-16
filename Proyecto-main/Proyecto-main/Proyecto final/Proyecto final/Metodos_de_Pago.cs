using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    internal class Metodos_de_Pago
    {
        private int _codigoPago;
        private string _metodo;

        public int CodigoPago { get => _codigoPago; set => _codigoPago = value; }
        public string Metodo { get => _metodo; set => _metodo = value; }

        public Metodos_de_Pago()
        {
        }

        public Metodos_de_Pago(int codigoPago, string metodo)
        {
            CodigoPago = codigoPago;
            Metodo = metodo;
        }

        public override string? ToString()
        {
            return "\nCodigo de Pago: " + this.CodigoPago
                + "\nMetodo: " + this.Metodo;
        }
    }
}
