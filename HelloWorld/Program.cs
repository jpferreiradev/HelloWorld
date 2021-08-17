using System;
// Esse módulo serve para que o c# seja capaz de manipular coisas do SO usúario
using System.Collections.Generic;
// Faz parte do System
using System.Linq;
// Trabalhar com uma quantidade muito grande de dados
using System.Text;
// Permite que você manipule o texto
using System.Threading.Tasks;
// Serve para criar um programa que roda em vários núcleos do processador ( Multitread) 
using System.IO;
// Serve para você manipular arquivos do seu computador

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // Int - Armazer dados que são números inteiros: 156 como 323232
            // Float - -15.6 como 232.132  ==> Double \| Decimal
            // Bool - True ou false 
            //String - "idwjdidjwi" Tipo texto 
            // Char - 'a'


            //declaração de variaveis:
            // A-Z
            // 0 -9 
            // @ $ 
            // _ 

            // Tipos de variaveis
            int segundaGuerraMundial = 1942;
            string corFavorita = "Black";
            float velocidadeF1 = 126.47f;
            bool segundaGuerraMundialAconteceu = true;


            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);
            

            velocidadeF1 = 348.29f;
            corFavorita = "Red";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(corFavorita);


            //Console.WriteLine("Vamos caraio");

            /* Outro tipo de declaração da variavel| Maneira preguiça
            var corrFavorita = "Vermelho";
            var modeloDoProduto = 2323;
             */

            /* 3 forma de declarar variavel, do topo dynamic, tipo dinamica
            dynamic cor_favorita = "Vermelho";

            Console.WriteLine(cor_favorita);

            cor_favorita = 12121212;

            Console.WriteLine(cor_favorita);

            cor_favorita = 3232323.2333f;

            Console.WriteLine(cor_favorita);
            */

             Console.ReadLine();

            
        }
    }
}
