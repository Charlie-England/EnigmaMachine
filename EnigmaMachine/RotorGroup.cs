using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    public class RotorGroup
    {
        public Rotor Rotor1;
        public Rotor Rotor2;
        public Rotor Rotor3;
        public Reflector Reflector;

        public RotorGroup(Rotor _rotor1, Rotor _rotor2, Rotor _rotor3, Reflector _reflector)
        {
            Rotor1 = _rotor1;
            Rotor2 = _rotor2;
            Rotor3 = _rotor3;
            Reflector = _reflector;
        }

        public char RotorEncrypt(char i)
        {
            //takes a single char as an input
            //First, uses FlipRotors to set rotor positions
            //Then uses the RotorWireEncrypt methods on each rotor to get the return char value
            FlipRotors();
            int curChar = Convert.ToInt32(i)-96;

            curChar = Rotor1.RotorWireEncrypt(curChar, 'f');
            curChar = Rotor2.RotorWireEncrypt(curChar, 'f');
            curChar = Rotor3.RotorWireEncrypt(curChar, 'f');
            curChar = Reflector.GetReflection(curChar);
            curChar = Rotor3.RotorWireEncrypt(curChar, 'r');
            curChar = Rotor2.RotorWireEncrypt(curChar, 'r');
            curChar = Rotor1.RotorWireEncrypt(curChar, 'r');


            return Convert.ToChar(curChar+96);

        }

        private void FlipRotors()
        {
            //iterates the position by one in the first rotor, checks if flip
            //if flip, iterates position in next rotor and checks if flip
            //if flip, iterates position in the 3rd rotor and stops
            bool flipCheck = Rotor1.IterateOne();
            if (flipCheck)
            {
                flipCheck = Rotor2.IterateOne();
            }
            if (flipCheck)
            {
                Rotor3.IterateOne();
                Rotor2.IterateOne();
            }
        }
    }
}
