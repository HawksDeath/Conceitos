using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Conceitos_OriObj
{
    class Item
    {
        //Instancias de classe (field)
        public string NomeItem;
        public double ValorItem;
        public int QuantidadeItem;

        //Public ou private sao modificadores de acesso

        public double AtualizaInventario() //Essa linha inteira do metodo se chama: Assinatura do Metodo
        {
            return ValorItem * QuantidadeItem;
        }

        public void AdicionaItens(int quantidade)
        {
            QuantidadeItem += quantidade;
        }

        public void RemoveItens(int quantidade)
        {
            QuantidadeItem -= quantidade;
        }

        public override string ToString()
        {
            return NomeItem
                + ", $ "
                + ValorItem.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + QuantidadeItem
                + " unidades, Total: $"
                + AtualizaInventario().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
