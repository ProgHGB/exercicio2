using System;

namespace exercicio2 {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("PROGRAMA QUE DEFINE QUANTAS PESSOAS TEM MAIS DE 18 ANOS");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();

            int qtde = 0;
            int idade = 0;
            
            int i = 0;
            while (i < 10) {
                i = i + 1;
                Console.Write("Informe a idade da pessoa: ");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade >= 18) {
                    qtde = qtde + 1;
                }
            }
            Console.WriteLine("Existem " + qtde + " pessoas com mais de 18 anos");
            Console.WriteLine();
            Console.WriteLine("****FIM DO PROGRAMA****");
            Console.ReadKey();
        }

       

    }

}
