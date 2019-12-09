using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 开机记单词
{
    public static class PublicElement
    {
        private static DataTable dt = null;
        private static int dtSize = 15000;
        public static DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        public static int DtSize
        {
            get { return dtSize; }
            set { dtSize = value; }
        }
    }
}
