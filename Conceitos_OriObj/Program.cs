using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;


namespace Conceitos_OriObj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar a classe Item
            Item i = new Item();

            WriteLine("Entre com os dados do Item: ");
            Write("Nome do Item: ");
            i.NomeItem = ReadLine();

            Write("Valor do Item: ");
            i.ValorItem = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            Write("Quantidade no inventario: ");
            i.QuantidadeItem = int.Parse(ReadLine());

            WriteLine();
            Write("Dados do Item: " + i);

            WriteLine("");
            Write("Digite o numero de itens a ser adicionado ao inventario: ");
            int qtdA = int.Parse(ReadLine());
            i.AdicionaItens(qtdA);

            WriteLine("");
            WriteLine("Dados atualizados: " + i);

            WriteLine("");
            Write("Digite o numero de itens a ser removido do inventario: ");
            int qtdR = int.Parse(ReadLine());
            i.RemoveItens(qtdR);

            WriteLine("");
            WriteLine("Dados atualizados: " + i);
            

            WriteLine("");
        }
    }
}
