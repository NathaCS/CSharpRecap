using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecap
{
    interface IHumanAction
    {
       //Every Human must be able to Talk
        void Talk(String message);
    }
}
