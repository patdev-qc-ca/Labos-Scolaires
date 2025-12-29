using System;

namespace _2Equation2Inconnus1erDegreProgram
{
    class Program
    {
        static void Resoudre(ref double x, ref double y, double z, ref double x1, ref double y1, double z1)
        {
            double b = y / x;
            double c = z / x;
            int e = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Formulation: {x}x-{y}y={z}");
            Console.WriteLine($"Formulation: {x1}x+{y1}y={z1}");
            Console.WriteLine($"Etape {e++}: {x}x+{y}y={z}");
            Console.WriteLine($"Etape {e++} :{x}x+{y}y-{z}=0");
            Console.WriteLine($"Etape {e++} :x+{b}y={c}");
            Console.WriteLine($"Etape {e++} :x+{b}y-{c}=0");
            Console.WriteLine($"Etape {e++} :{x}x+{y}y-{c}={x1}x+{y1}y-{z1}");
            Console.WriteLine($"Etape {e++} :{x - x1}x+{y - y1}y-{z - z1}=0");
            Console.WriteLine($"Etape {e++} :Y=({y - y1}y-{z - z1})/{x - x1}={((z - z1) - (y - y1)) / (x - x1)}");
            if (((y - y1) - (z - z1)) / (x - x1) < 0)
            {
                Console.WriteLine($"Etape {e++} :Y={(((y - y1) - (z - z1)) / (x - x1) * (-1))}");
            }
            double y2 = Math.Truncate((((y - y1) - (z - z1)) / (x - x1) * (-1)));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Etape {e++} :Y={y2}");
            Console.WriteLine($"Etape {e++} :X=({z}-{y2}*{y})/{x}={ (z - y2 * y) / x}");
            double x2 = Math.Truncate((z - y2 * y) / x);
            Console.WriteLine($"Etape {e++} :X={x2}");
            for (int a = 1; a <= Math.Truncate(c); a++)
            {
                for (int d = 1; d <= Math.Truncate(c); d++)
                {
                    if ((a * x + d * y) == z)
                    {
                        if ((x1 * a) + (y1 * d) == z1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"\n\nSolution:  x={a}; y={d}\n");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($"\nEtape {e++} test f({x2}):{(z - y2 * y) / x}*{x}+{y2}*{y}={(z - y2 * y) / x * x}+{y2 * y}=");
            if ((z - y2 * y) / x * x + y2 * y == z)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"{ (z - y2 * y) / x * x + y2 * y}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"Etape {e} test f'({x2 }):{(z - y2 * x) / y}*{x1}+{y2}*{y1}={ (z - y2 * y) * x1 / x}+{y1 * y2}=");
            if ((x1 * (z - y2 * y) / x + y1 * y2) == z1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"{x1 * (z - y2 * y) / x + y1 * y2}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            double x, y, z, x1, y1, z1;
            Console.Title = "Logiciel de resolution 2 equations 2 inconnus 1er degre";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Hello Equation2Inconnus1erDegre!          Créé par Patrice Waechter-Ebling 2022      v:1.0.0.a");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Entrez le nombre de X: "); x = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("Entrez le nombre de Y: "); y = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("Entrez le nombre de la constante: "); z = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("Equation 2\nEntrez le nombre de X: "); x1 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("Entrez le nombre de Y: "); y1 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("Entrez le nombre de la constante: "); z1 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Resoudre(ref x, ref y, z, ref x1, ref y1, z1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Appuyez une touche pour quitter "); Console.ReadKey();
        }
    }
}
