using System;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 =new Produto(1,"FIFA 20",199.99f);
            Produto p2 = new Produto(2,"GTA V",199.99f);
            Produto p3 = new Produto(3,"Rainbow Six",179.99f);
            Produto p4 = new Produto(4,"Watch Dogs 2",159.99f);

            Carrinho carrinho = new Carrinho();
            carrinho.AddProduto(p1);
            carrinho.AddProduto(p2);
            carrinho.AddProduto(p3);
            carrinho.AddProduto(p4);

            carrinho.MostrarCarrinho();
            System.Console.WriteLine();
            
            carrinho.RemoverProduto(p4);

            carrinho.MostrarCarrinho();
            System.Console.WriteLine();
            
            Produto p5 = new Produto(1,"GTA san andreas",153.99f);
            carrinho.Alterar(1,p5);
            carrinho.MostrarCarrinho();
            carrinho.MostrarTotal();
        }
    }
}
