using System;

namespace Uri1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, menor, maior, soma;

            soma = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x >= y)
            {
                maior = x;
                menor = y;
            }
            else
            {
                maior = y;
                menor = x;
            }

            for (int c = menor; c < maior; c++)
            {
                if (c % 5 == 2 ||c%5 ==3 )
                {
                    Console.WriteLine(c);
                }


            }
        }
    }
}
