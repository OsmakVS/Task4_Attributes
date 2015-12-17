using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Attributes
{
    class TestClass
    {
        private string fStr;
        private string sStr;
        private string tStr;
        [ColorAttribute("red")]
        public string Fstr
        {
            get { return fStr; }
            set { fStr = value; }
        }
        [ColorAttribute("blue")]
        public string Sstr
        {
            get { return sStr; }
            set { sStr = value; }
        }
        public string Tstr
        {
            get { return tStr; }
            set { tStr = value; }
        }
        public TestClass(string fStr, string sStr, string tStr)
        {
            this.Fstr = fStr;
            this.Sstr = sStr;
            this.Tstr = tStr;
        }
    }
}
