using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    internal class PedidoLocal : Pedido
    {
        private double _PctServico = 0.10;

        public PedidoLocal() : base() {}

        private double TaxaServico()
        {
            return base.PrecoAPagar() * _PctServico;
        }

        public override double PrecoAPagar()
        {
            return base.PrecoAPagar() + TaxaServico();
        }

        protected override string RodapePedido()
        {
            StringBuilder relat = new StringBuilder();
            relat.AppendLine($"TAXA DE SERVIÇO: {TaxaServico():C2}");
            relat.AppendLine($"\nTOTAL DO PEDIDO: {PrecoAPagar():C2}");
            return relat.ToString();
        }
    }
}
