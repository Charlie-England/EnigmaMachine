using System;
using System.Collections.Generic;

namespace EnigmaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fop1 = { 18, };
            int[] fop2 = { 6, };
            int[] fop3 = { 23, };

            Rotor rotor1 = new Rotor("Rotor III", 0, fop3);
            Rotor rotor2 = new Rotor("Rotor II", 0, fop2);
            Rotor rotor3 = new Rotor("Rotor I", 0, fop1);
            Reflector reflector = new Reflector("B");

            RotorGroup rg = new RotorGroup(rotor1, rotor2, rotor3, reflector);

            Console.WriteLine(rg.RotorEncrypt('a'));
            Console.WriteLine(rg.RotorEncrypt('a'));
            Console.WriteLine(rg.RotorEncrypt('a'));
            Console.WriteLine(rg.RotorEncrypt('a'));
            Console.WriteLine(rg.RotorEncrypt('a'));

            /*            Console.WriteLine(rg.RotorEncrypt('p'));
                        Console.WriteLine(rg.RotorEncrypt('x'));
                        Console.WriteLine(rg.RotorEncrypt('v'));
                        Console.WriteLine(rg.RotorEncrypt('i'));
                        Console.WriteLine(rg.RotorEncrypt('g'));*/

        }
    }
}
