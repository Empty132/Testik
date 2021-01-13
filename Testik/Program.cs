using System;

namespace Testik
{
    class Program
    {
        static void Main(string[] args)
        {
            float v;
            string s;


            Console.WriteLine("Napis nejaky priklad");

            s = Console.ReadLine();

            char[] characters = s.ToCharArray();
            int caseSwitch=0;
            string[] array = null ;
            foreach (var ch in characters)
            {
                if(ch == '*')
                {
                    caseSwitch = 1;
                    array = s.Split('*');
                }
                else if(ch == '/')
                {
                    caseSwitch = 2;
                    array = s.Split('/');

                }
                else if(ch == '+')
                {
                    caseSwitch = 3;
                    array = s.Split('+');

                }
                else if (ch == '-')
                {
                    caseSwitch = 4;
                    array = s.Split('-');

                }
                else { }

            }

            float fn, sn;
            try
            {
                fn = float.Parse(array[0]);
                sn = float.Parse(array[1]);

                switch (caseSwitch)
                {
                    //*
                    case 1:
                        v = fn * sn;
                        Console.WriteLine("Vysledek je: " + v);
                        break;
                    // deleni
                    case 2:
                        v = fn / sn;
                        Console.WriteLine("Vysledek je: " + v);
                        break;
                    // +
                    case 3:
                        v = fn + sn;
                        Console.WriteLine("Vysledek je: " + v);
                        break;
                    // -
                    case 4:
                        v = fn - sn;
                        Console.WriteLine("Vysledek je: " + v);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Zadal jsi spatny symbol");
            }


         }
    }
}
