using System;
using System.Collections.Generic;
namespace Aula24
{
    public class Carrinho
    {

        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();
        
        public void AddProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void MostrarCarrinho()
        {
            foreach (Produto item in carrinho)
            {
              Console.WriteLine($"Nome do jogo: {item.Nome} preço R$:{item.Preco}");
                
            }
        }

        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void MostrarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;

            }
            Console.WriteLine($"Total R$:{ValorTotal}");
        }

            public void Alterar(int _codigo, Produto _produtoAlterado){
                carrinho.Find(y => y.Codigo == _codigo).Nome = _produtoAlterado.Nome;
                carrinho.Find(y => y.Codigo == _codigo).Preco = _produtoAlterado.Preco;

            }
     
    }
}