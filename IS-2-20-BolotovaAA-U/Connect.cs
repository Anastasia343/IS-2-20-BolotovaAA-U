using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_2_20_BolotovaAA_U
{
    internal class Connect
    {
        public static string ConnectStr;

        public Connect(string connectStr)
        {
            ConnectStr = connectStr;
        }

        public static string RetStr()
        {
            return ConnectStr;
        }
    }
}
