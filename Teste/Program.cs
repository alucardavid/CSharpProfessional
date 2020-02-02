using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            CantChange(new AValueType());
        }

        static void TesteParams(params int[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        }

        static void CantChange(in AValueType a)
        {
            a.Data = 45;

            Console.WriteLine(a.Data);
        }

    }
 
}
