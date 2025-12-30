using System;

namespace TP1
{
    class Program
    {
        public static string nom,prenom;
        static void Main()
        {
            MethodeA();
            Console.WriteLine("======================================");
            MethodeB();
            Console.WriteLine("Appuyez sur Entrée pour quitter ce programme");
            Console.ReadLine();
        }

        static void MethodeA()
        {
            Console.Write("veuillez svp entrer votre prénom : ");
            prenom = Console.ReadLine();
            Console.Write("veuillez svp entrer votre nom : ");
            nom = Console.ReadLine();
            Console.WriteLine("------------------------------------>");
            Console.WriteLine($"Reformatage #1 : {nom} {prenom}");
            Console.WriteLine($"Reformatage #2 : {nom}, {prenom[0]} ");
            Console.WriteLine($"Reformatage #3 : {nom}, {prenom[0].ToString().ToUpper()}.");
            string var1 = $"{prenom[0].ToString().ToUpper()}{prenom.Substring(1)}";
            Console.WriteLine($"Reformatage #4 : {nom.ToUpper()}, {var1}");
            Console.WriteLine($"Reformatage #5 : {prenom[0].ToString().ToUpper()}.{nom[0].ToString().ToUpper()}. ");
            var1 = $"{prenom[0]}{prenom[1]}{prenom[2]}{nom[0]}{nom[1]}1";
            Console.WriteLine($"Reformatage #6 : {var1}");
        }

        static void MethodeB()
        {
            double c,dx,dy;
            Console.Write("veuillez svp entrer un nombre entier : ");
            dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("veuillez svp entrer à nouveau un nombre entier : ");
            dy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------>");
            int a = Convert.ToInt32(dx);
            int b = Convert.ToInt32(dy);
            Console.WriteLine($"Somme {a}+{b} = {a + b}");
            Console.WriteLine($"Multiplication {a} x {b} = {a * b}");
            c = a / b;
            Console.WriteLine("--------");
            Console.WriteLine($"Division1 {a}/{b} = {c}");
            c = dx / dy;
            Console.WriteLine($"Division1 {a}/{b} avec décimal = {c}");
            c = b / a;
            Console.WriteLine("--------");
            Console.WriteLine($"Division2 {b}/{a} = {c}");
            c = dy / dx;
            Console.WriteLine($"Division2 {b}/{a} avec decimal = {c}");
            Console.WriteLine("--------");
            Console.WriteLine($"Table de multiplication de {a}");
            Console.WriteLine($"{a} x {1}={a * 1}\n{a} x {2}={a * 2}\n{a} x {3}={a * 3}\n{a} x {4}={a * 4}\n{a} x {5}={a * 5}\n{a} x {6}={a * 6}\n{a} x {7}={a * 7}\n{a} x {8}={a * 8}\n{a} x {9}={a * 9}\n{a} x {10}={a * 10}");
            Console.WriteLine("--------");
            Console.WriteLine($"Table de multiplication de {b}");
            Console.WriteLine($"{b} x {1}={b * 1}\n{b} x {2}={b * 2}\n{b} x {3}={b * 3}\n{b} x {4}={b * 4}\n{b} x {5}={b * 5}\n{b} x {6}={b * 6}\n{b} x {7}={b * 7}\n{b} x {8}={b * 8}"); }
        /*
         * desactive car pas vu en classe
         * 
         *Console.WriteLine($"Table de multiplication de {a}");
         * for (int x = 1; x < 11; x++) {Console.WriteLine($"{a}x{x}={a * x}");}
         * Console.WriteLine("--------");
         * Console.WriteLine($"Table de multiplication de {b}");
         *for (int x = 1; x < 9; x++){Console.WriteLine($"{b}x{x}={b * x}");}
         */
    }
}
