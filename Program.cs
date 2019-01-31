using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palin
{
    class Program
    {
        static void Main(string[] args)
        {
            string palin = "leel";
            string drone = "drone";
            CheckPalin(palin);
            CheckPalin(drone);
        }

        static void CheckPalin(string s)
        {
            bool isPal = true;
            for (int i = 0; i < s.Length - 1; i++)
            {
                int j = s.Length - 1 - i;
                if (s[i]!= s[j])
                {
                    isPal = false;
                    break;
                }
                if (i>=j)
                {                 
                    break;
                }
                
            }
            if (isPal)
            {
                Console.WriteLine("isPal");
            }
            else
            { 
                Console.WriteLine("not pal");
            }
        }
    }
}
