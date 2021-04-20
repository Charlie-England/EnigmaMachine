using System;
using System.Collections.Generic;

namespace EnigmaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fop1 = new List<int> { 17, }; //rotor FoP are 0-25 (offset amounts) so If stepping from V-W it would normally be 22-23 but will be stepping 21-22 with 0 base
            List<int> fop2 = new List<int> { 5, };
            List<int> fop3 = new List<int> { 22, };

            Rotor rotor1 = new Rotor("Rotor III", 0, fop3);
            Rotor rotor2 = new Rotor("Rotor II", 0, fop2);
            Rotor rotor3 = new Rotor("Rotor I", 0, fop1);
            Reflector reflector = new Reflector("B");

            RotorGroup rg = new RotorGroup(rotor1, rotor2, rotor3, reflector);

            int count = 0;
            int count2 = 0;
            foreach (char c in "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")
            {
                count2++;
                if (count == 5)
                {
                    Console.WriteLine();
                    count = 0;
                }
                count++;

                Console.Write(rg.RotorEncrypt(c));
            }
            Console.WriteLine();

            count = 0;
            foreach (char c in "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")
            {
                count2++;
                if (count == 5)
                {
                    Console.WriteLine();
                    count = 0;
                }
                count++;

                if (count2 == 100)
                {
                    Console.Write("");
                }

                Console.Write(rg.RotorEncrypt(c));
            }


        }
    }
}
