using System;

namespace PaginaçaoRegexHardXpath
{
    class ProgramaInteiro
    {
        static void Main(string[] args)
        {
            
        }

        public virtual void EscreveMensagem()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }
    }

    class ProgramaNovo : ProgramaInteiro
    {
        static void Main(string[] args)
        {

        }

        public override void EscreveMensagem()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Auxiliar
    {
        public void RecebePrograma(ProgramaInteiro inteiro)
        {

        }
    }
}
