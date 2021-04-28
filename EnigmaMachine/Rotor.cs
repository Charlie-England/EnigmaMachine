using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    public class Rotor
    {
        public string Name { get; set; }
        public int RotorOffset { get; set; }
        public int[] FlipOverPoint;
        private Dictionary<int, int> RotorWiring;

        public Rotor(string _name, int _currentrotorstatus, int[] _flipoverpoint)
        {
            Name = _name;
            RotorOffset = _currentrotorstatus;
            FlipOverPoint = _flipoverpoint;
            RotorWiring = GetRotorWiring();
        }

        public bool IterateOne()
        {
            //Iterate the CurrentRotorStatus by 1, checking for flip over and return 'f' if next rotor should flip over, return 'c' if not

            //Iterate RotorStatus by 1, reset to a if needed.
            RotorOffset++;
            if (RotorOffset == 27) //this is the char after z
            {
                RotorOffset = 0;
            }

            //Check for flip over point
            foreach (int flipNum in FlipOverPoint)
            {
                if (flipNum == RotorOffset)
                {
                    return true;
                }
            }

            return false;
        }

        public int RotorWireEncrypt(int input, char direction)
        {
            //Console.WriteLine($"{Name} in << {input}");

            input += RotorOffset; //Add to the input due to offsetting of the rotor
            //Console.WriteLine($"{Name} Offset Convert << {input}");

            //input +=Rotoroffset % 26
            if (input > 26) //If the input is greater than 26, find the remainder (due to rotors being circular with only 26 places)
            {
                input = input % 26;
            }

            int encryptOut = 0;
            if (direction == 'f') //If the direction is forward, do normal RotorWiring
            {
                encryptOut = RotorWiring[input];
            } else if (direction == 'r') //If the position is reverse, use method to find the value and return the key of that value simulating signal traveling back through
            {
                encryptOut = FindReverseWiring(input); 
            }
            //Console.WriteLine($"{Name} encrypt change {encryptOut}");
            encryptOut -= RotorOffset; //the output needs to be modified if the rotor is offset at all.

            if (encryptOut < 0)
            {
                encryptOut = 26 % encryptOut;
            } else if (encryptOut == 0)
            {
                encryptOut = 26;
            }
            //Console.WriteLine($"{Name} number going into next rotor {encryptOut}");
            //Console.WriteLine();
            return encryptOut;
        }

        private int FindReverseWiring(int input)
        {
            foreach (KeyValuePair<int, int> kvp in RotorWiring)
            {
                if (kvp.Value == input)
                {
                    return kvp.Key;
                }
            }

            return -1;
        }

        private Dictionary<int, int> GetRotorWiring()
        {
            Dictionary<int, int> rotorWiring = new Dictionary<int, int>();

            if (Name.Equals("Rotor I"))
            {
                rotorWiring.Add(1, 5);
                rotorWiring.Add(2, 11);
                rotorWiring.Add(3, 13);
                rotorWiring.Add(4, 6);
                rotorWiring.Add(5, 12);
                rotorWiring.Add(6, 7);
                rotorWiring.Add(7, 4);
                rotorWiring.Add(8, 17);
                rotorWiring.Add(9, 22);
                rotorWiring.Add(10, 26);
                rotorWiring.Add(11, 14);
                rotorWiring.Add(12, 20);
                rotorWiring.Add(13, 15);
                rotorWiring.Add(14, 23);
                rotorWiring.Add(15, 25);
                rotorWiring.Add(16, 8);
                rotorWiring.Add(17, 24);
                rotorWiring.Add(18, 21);
                rotorWiring.Add(19, 19);
                rotorWiring.Add(20, 16);
                rotorWiring.Add(21, 1);
                rotorWiring.Add(22, 9);
                rotorWiring.Add(23, 2);
                rotorWiring.Add(24, 18);
                rotorWiring.Add(25, 3);
                rotorWiring.Add(26, 10);
            } else if (Name.Equals("Rotor II"))
            {
                rotorWiring.Add(1, 1);
                rotorWiring.Add(2, 10);
                rotorWiring.Add(3, 4);
                rotorWiring.Add(4, 11);
                rotorWiring.Add(5, 19);
                rotorWiring.Add(6, 9);
                rotorWiring.Add(7, 18);
                rotorWiring.Add(8, 21);
                rotorWiring.Add(9, 24);
                rotorWiring.Add(10, 2);
                rotorWiring.Add(11, 12);
                rotorWiring.Add(12, 8);
                rotorWiring.Add(13, 23);
                rotorWiring.Add(14, 20);
                rotorWiring.Add(15, 13);
                rotorWiring.Add(16, 3);
                rotorWiring.Add(17, 17);
                rotorWiring.Add(18, 7);
                rotorWiring.Add(19, 26);
                rotorWiring.Add(20, 14);
                rotorWiring.Add(21, 16);
                rotorWiring.Add(22, 25);
                rotorWiring.Add(23, 6);
                rotorWiring.Add(24, 22);
                rotorWiring.Add(25, 15);
                rotorWiring.Add(26, 5);
            } else if (Name.Equals("Rotor III"))
            {
                rotorWiring.Add(1, 2);
                rotorWiring.Add(2, 4);
                rotorWiring.Add(3, 6);
                rotorWiring.Add(4, 8);
                rotorWiring.Add(5, 10);
                rotorWiring.Add(6, 12);
                rotorWiring.Add(7, 3);
                rotorWiring.Add(8, 16);
                rotorWiring.Add(9, 18);
                rotorWiring.Add(10, 20);
                rotorWiring.Add(11, 24);
                rotorWiring.Add(12, 22);
                rotorWiring.Add(13, 26);
                rotorWiring.Add(14, 14);
                rotorWiring.Add(15, 25);
                rotorWiring.Add(16, 5);
                rotorWiring.Add(17, 9);
                rotorWiring.Add(18, 23);
                rotorWiring.Add(19, 7);
                rotorWiring.Add(20, 1);
                rotorWiring.Add(21, 11);
                rotorWiring.Add(22, 13);
                rotorWiring.Add(23, 21);
                rotorWiring.Add(24, 19);
                rotorWiring.Add(25, 17);
                rotorWiring.Add(26, 15);
            }

            return rotorWiring;
        }
    }
}
