using System;

namespace APSL_P_III_Zad3
{
    class Program
    {
        public delegate void ciag (int n, int a, int p);
        static void Main(string[] args)
        {
            Console.Clear();
            Random r = new Random();
            int los = r.Next(3,11); //zmienilem z 1-5 bo nie bylo nic widac
            //int los = r.Next(1,5);
            void ciagArytm(int n, int a, int p)
            {
                int liczba = a;
                for(int i=0;i<n;i++){Console.Write("{0} ",liczba);liczba=liczba+p;}
                Console.WriteLine();
            }
            void ciagGeo(int n, int a, int p)
            {
                int liczba = a;
                for(int i=0;i<n;i++){Console.Write("{0} ",liczba);liczba=liczba*p;}
                Console.WriteLine();
            }

            ciag c;
            c=ciagArytm;
            c=c+ciagGeo;

            Console.Write("Generowac ciag [A]rytmetyczny czy [G]eometryczny?");
            string znak = Console.ReadLine();
            Console.Write("Podaj pierwszy element: ");
            int p1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj roznice: ");
            int p2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTwoj ciag:");
            if(znak.ToUpper()=="G"){c=c-ciagArytm;c(los,p1,p2);c=c+ciagArytm;}
            if(znak.ToUpper()=="A"){c=c-ciagGeo;c(los,p1,p2);c=c+ciagGeo;}
            Console.WriteLine("\nOba ciagi:");
            c(los,p1,p2);  
        }
    }
}

