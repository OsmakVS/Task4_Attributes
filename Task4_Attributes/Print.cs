using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Attributes
{
    class Print
    {
        public void cPrint(object obj)
        {
            Type objTp = obj.GetType();
            PropertyInfo[] array = objTp.GetProperties();
            foreach (PropertyInfo pnfo in array)
            {
                object[] property = pnfo.GetCustomAttributes(false);
                if (System.Attribute.IsDefined(pnfo, typeof(ColorAttribute)))
                {
                    var atr = System.Attribute.GetCustomAttribute(pnfo, typeof(ColorAttribute)) as ColorAttribute;
                    if (atr.color == "blue")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    if (atr.color == "red")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(pnfo.GetValue(obj).ToString());
            }
        }
    }
}
