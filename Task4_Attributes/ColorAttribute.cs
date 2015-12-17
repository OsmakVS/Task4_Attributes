using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColorAttribute : System.Attribute
    {
        public string color;
        public ColorAttribute()
        {

        }
        public ColorAttribute(string color)
        {
            this.color = color;
        }
    }
}
