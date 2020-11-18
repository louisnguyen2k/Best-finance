using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class Commom
    {
        public static int clone_nguoi_quen = 13;

        public static float DOLA = 1;
        public static float VND = 23000;

        public static string StrDOLA = "$";
        public static string StrVND = "VND";

        // chuyển tiền từ id_v1 sang id_v2 với số tiền là money
        public static string ConvertMoney(string id_v1, string id_v2, float money)
        {
            float fmoney = money;
            if (id_v1 == StrDOLA && id_v2 == StrVND)
            {
                fmoney = money * VND;
            }
            else if (id_v1 == StrVND && id_v2 == StrDOLA)
            {
                fmoney = money / DOLA;
            }
            return fmoney.ToString();
        }



        public static string getMoneyStr(string Money)
        {
            if (Money == string.Empty || Money == null)
                return "";
            float fmoney = float.Parse(Money);

            decimal decimal_value = Math.Round(Convert.ToDecimal(fmoney), 2);

            string[] listStr = decimal_value.ToString().Split('.');

            char[] listChar = listStr[0].ToCharArray(); // 1 - 2

            string result = "";
            int count = 0;
            for (int i = listChar.Length - 1; i >= 0; i--)
            {
                if (count % 3 == 0 && count != 0 && listChar[i] != '-')
                {
                    result += "," + listChar[i];
                }
                else
                {
                    result += listChar[i];
                }
                count++;
            }



            if (listStr.Length == 1)
            {
                return Reverse(result) + " ";
            }
            else
            {
                return Reverse(result) + "." + listStr[1] + " ";
            }

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }



        public static Image getImage(string img)
        {
            try
            {
                return Image.FromFile("../../icon/" + img);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        // get sunday
        public static DateTime FirstDayOfWeek(DateTime dt)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = dt.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            return dt.AddDays(-diff).Date;
        }

    }
}
