using System;

namespace _17.nestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out  all four digit numbers in format ABCD such that : A+B = C + D ;( happy numbers) 

            for (int a = 1; a <= 9 ; a++)
            {
                for (int b = 0; b <= 9 ; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <= 9 ; d++)
                        {
                            if ((a + b) == (c + d)) 
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Hurahhh");
        }
    }
}
