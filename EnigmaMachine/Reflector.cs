using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    public class Reflector
    {
        public Dictionary<int, int> ScramblerDict;
        public string Type;

        public Reflector(string _type)
        {
            Type = _type;
            ScramblerDict = GetTypeCode();
        }

        private Dictionary<int, int> GetTypeCode()
        {
            Dictionary<int, int> RefType = new Dictionary<int, int>();

            if (Type.Equals("A"))
            {
                RefType.Add(1, 5);
                RefType.Add(2, 10);
                RefType.Add(3, 13);
                RefType.Add(4, 26);
                RefType.Add(5, 1);
                RefType.Add(6, 12);
                RefType.Add(7, 25);
                RefType.Add(8, 24);
                RefType.Add(9, 26);
                RefType.Add(10, 2);
                RefType.Add(11, 23);
                RefType.Add(12, 6);
                RefType.Add(13, 3);
                RefType.Add(14, 18);
                RefType.Add(15, 17);
                RefType.Add(16, 21);
                RefType.Add(17, 15);
                RefType.Add(18, 14);
                RefType.Add(19, 20);
                RefType.Add(20, 19);
                RefType.Add(21, 16);
                RefType.Add(22, 9);
                RefType.Add(23, 11);
                RefType.Add(24, 8);
                RefType.Add(25, 7);
                RefType.Add(26, 4);
            } else if (Type.Equals("B"))
            {
                RefType.Add(1, 25);
                RefType.Add(2, 18);
                RefType.Add(3, 21);
                RefType.Add(4, 8);
                RefType.Add(5, 17);
                RefType.Add(6, 19);
                RefType.Add(7, 12);
                RefType.Add(8, 4);
                RefType.Add(9, 16);
                RefType.Add(10, 24);
                RefType.Add(11, 14);
                RefType.Add(12, 7);
                RefType.Add(13, 15);
                RefType.Add(14, 11);
                RefType.Add(15, 13);
                RefType.Add(16, 9);
                RefType.Add(17, 5);
                RefType.Add(18, 2);
                RefType.Add(19, 6);
                RefType.Add(20, 26);
                RefType.Add(21, 3);
                RefType.Add(22, 23);
                RefType.Add(23, 22);
                RefType.Add(24, 10);
                RefType.Add(25, 1);
                RefType.Add(26, 20);
            }

            return RefType;
        }

        public int GetReflection(int i)
        {
            return ScramblerDict[i];
        }
    }
}
