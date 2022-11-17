using System;
using System.Globalization;

namespace Hotel
{
    class Program
    {
        static void Main(string[]args)
        {

            Hospedes[] hospedes = new Hospedes[9];
            Console.Write("DIGITE QUANTOS QUARTOS DESEJA ALUGAR: " );
            int quartos = int.Parse( Console.ReadLine());
            Console.WriteLine();



            for (int i = 1; i <= quartos; i++)
            {
                Console.WriteLine("HOSPEDE: " + i);
                Console.Write("DIGITE SEU NOME: ");
                string nome = Console.ReadLine();
                Console.WriteLine();

                Console.Write("DIGITE SEU EMAIL: ");
                string email = Console.ReadLine();
                Console.WriteLine();

                Console.Write("DIGITE  O NUMERO DO QUARTO DESEJADO: ");
                int quarto = int.Parse( Console.ReadLine());
                Console.WriteLine();

                hospedes[quarto] = new Hospedes (nome,email);
            }


            Console.WriteLine();
            Console.WriteLine("QUARTOS OCUPADOS:");
            for(int i = 0; i < 9; i++)
            {
                if(hospedes[i] != null)
                {
                    Console.WriteLine("QUARTO NUMERO " +i + " : " + hospedes[i]);
                }
            }
        }
    }
}