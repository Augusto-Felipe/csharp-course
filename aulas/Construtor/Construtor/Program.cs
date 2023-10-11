﻿using Construtor.Entities;
using System.Globalization;

namespace Construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto;
            Produto produto2;

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            produto = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine() ;

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}