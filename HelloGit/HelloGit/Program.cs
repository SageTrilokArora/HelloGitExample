using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Git! --- 111");
            Console.WriteLine("Todays fortunre = " + GetFortune());
            Console.ReadKey();
        }

        static string GetFortune()
        {
            Random r = new Random();
            int whichOne = r.Next(56);
            switch (whichOne % 4)
            {
                case 0:
                    return "this is 0";
                    
                case 1:
                    return "this is 1";
                    
                case 2:
                    return "this is 2";
                    
                case 3:
                    return "this is 3";
                    
                default:
                    return "In default";

            }
        }
    }
}
