using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _7Kyu;
using _6kyu;

namespace TB.Codewars.Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingGroups.Check("([{}{()}])");
            CheckingGroups.Check("{[([({]})}])");
            Console.ReadLine();
        }
    }
}
