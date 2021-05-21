using System;

namespace idadealuno
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nascimento = new DateTime(2001, 9, 23);
            DateTime dezoitoanos = new DateTime(2019, 9, 23);
            Console.WriteLine("Eu nasci em "+nascimento.ToLongDateString());
            Console.WriteLine("Meu aniversário de 18 anos foi em "+dezoitoanos.ToLongDateString());
        }
    }
}
