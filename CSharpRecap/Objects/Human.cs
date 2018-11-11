using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecap
{
    class Human : IHumanAction
    {
        public void Talk(String message)
        {
            Console.WriteLine(message);
        }
    }
}
