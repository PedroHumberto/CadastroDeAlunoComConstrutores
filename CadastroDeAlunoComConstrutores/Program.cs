using System;
using System.Globalization;

namespace CadastroDeAluno {
    class Program {
        static void Main(string[] args) {

           
            // entrada temporaria de dados para depois ser substituida pelo Student a, onde vai receber todos os valores citados
            // toranando assim a entrada inicial dos dados obrigatoria
            Console.Write("Student Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Type three notes:");
            double note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Student a = new Student(name, note1, note2, note3);

            Console.WriteLine("Final Note = " + a.FinalResult().ToString("F2", CultureInfo.InvariantCulture));
            if (a.Aproved()) {
                Console.WriteLine("Aproved");
            }


            else {
                Console.WriteLine("Reproved");

                Console.WriteLine("You need: "
                    + a.RestNote().ToString("F2", CultureInfo.InvariantCulture)
                    + " points");
            }


        }
    }
}