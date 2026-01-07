using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class DivideByZeroEx: Exception
    {
     public DivideByZeroEx(string message) : base(message)
        {
         
        }
     
    }
}
