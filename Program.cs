using System;

namespace _17.nestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out  all four digit numbers in format ABCD such that : A+B = C + D ;( happy numbers) 
            int counter = 0;
            for (int a = 1; a <= 9 ; a++)
            {
                for (int b = 0; b <= 9 ; b++)
                {
                    for (int c = 0; c <= 9; c++)   ///a+b-c = d; // d>=0 && d <=9  optinmised with  3 cycles not with 4
                    {
                            int d = a + b - c;   //a+b = c+d ;
                            if ( 0 <= d && d <= 9 ) 
                            {
                            //Console.WriteLine($"{a}{b}{c}{d}");
                              counter++;
                            }
                        
                    }
                }
            }
            Console.WriteLine("Hurahhh");
            Console.WriteLine(counter);
        }
    }
}
