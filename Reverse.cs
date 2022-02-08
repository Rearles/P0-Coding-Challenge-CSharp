using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0_Coding_Challenge_CSharp
{
    public class Reverse
    {
        public string ReverseCase(string toreverse)
        {
            string toreturn = "";
            foreach(char i in toreverse)
            {
                string k = i.ToString();
                if (k.ToUpper() == k) //if the original character is upppercase
                {
                    toreturn += k.ToLower();
                }
                else
                {
                    toreturn += k.ToUpper();
                }
            }
            return toreturn;
        }
    }
}
