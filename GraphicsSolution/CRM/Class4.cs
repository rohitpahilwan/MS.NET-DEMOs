using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Helper
    {
        public static void display(params string[] names)
        {
            foreach (string name in names)
            {

                Console.WriteLine(name);
            }
        }
    }
}
