using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPFApp
{
    public class Model
    {
        public string GetInfo(string fn, string ln, int age)
        {
            if (age > 18)
            {
                string fval = "Hello " + fn + " " + ln + " you have a right to VOTE!!!";
                return fval;
            }
            return "Hello " + fn + " " + ln + " you DONT have a right to VOTE!!!";
        }
    }
}
