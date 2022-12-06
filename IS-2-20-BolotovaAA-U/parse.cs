using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_2_20_BolotovaAA_U
{
    internal class parse
    {
        public static string GetMonth(string month)
        {

            switch (month)
            {
                case "01":
                    return "января";
                case "02":
                    return "февраля";
                case "03":
                    return "марта";
                case "04":
                    return "апреля";
                case "05":
                    return "мая";
                case "06":
                    return "июня";
                case "07":
                    return "июля";
                case "08":
                    return "августа";
                case "09":
                    return "сентября";
                case "10":
                    return "октября";
                case "11":
                    return "ноября";
                case "12":
                    return "декабря";
                default: return "";

            }
        }
        public static string Parser(string s)
        {
            string[] dateParts = s.Substring(0, 10).Split('.');


            string day = dateParts[0];
            string month = GetMonth(dateParts[1]);
            string year = dateParts[2];

            return $"{day} {month} {year} г.";
        }
    }
}
