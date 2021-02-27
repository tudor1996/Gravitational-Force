using System;

namespace C1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double g = 9.81, d = 0, dd;
            int t = 0;

            Console.Write("Dati distanta maxima ");
                try
            {
                dd = int.Parse(Console.ReadLine());
                while (d<=dd )
                {
                    d = (g * t * t) / 2;
                    Console.WriteLine(t.ToString() + " " + d);
                    t += 1;
                }
            }

                catch (Exception ex)
              {
                Console.WriteLine(ex.Message);
              }
                Console.ReadLine();
        }
        
          
    }
}
