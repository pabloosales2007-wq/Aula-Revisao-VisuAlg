using System;

namespace testepablo
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Write("pablo tem medo de inseto? ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                Console.WriteLine("pablo é frango");
            }
            else
                Console.WriteLine("boa pablo");
        }
    }
}
