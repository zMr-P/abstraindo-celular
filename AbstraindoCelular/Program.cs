using AbstraindoCelular.Models;
using System;
using System.Text;

namespace AbstraindoCelularOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone iphone = new Iphone("(21) 96769-7174", "A2483", "001970 - 01 - 010000 - 0", 128);
            Smartphone nokia = new Nokia("9485-6906", "3310", "001970 - 01 - 010000 - 1", 32);

            Console.WriteLine(iphone);
            iphone.Ligar(nokia);
            Console.WriteLine("\n" + nokia);
            nokia.ReceberLigacao(iphone);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(nokia);
            nokia.Ligar(iphone);
            Console.WriteLine("\n" + iphone);
            iphone.ReceberLigacao(nokia);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(iphone);
            iphone.InstalarAplicativo("WhatsApp", 45);
            Console.WriteLine("\n" + nokia);
            nokia.InstalarAplicativo("WhatsApp", 20);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(iphone);
            iphone.InstalarAplicativo("Instagram", 129);
            Console.WriteLine("\n" + nokia);
            nokia.InstalarAplicativo("", 25);
            
        }
    }
}