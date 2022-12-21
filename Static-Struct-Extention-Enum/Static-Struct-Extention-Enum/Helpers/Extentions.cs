using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//namespace Static_Struct_Extention_Enum.Helpers
//{
//    public static class Extentions

//    {
//        public static int GetNum(this int num)
//        {
//            return num;
//        }



//        public static bool CheckDigitInString(this string text)
//        {

//            return Regex.IsMatch(text, @"\d");

//        }

//    }


//}


namespace Static_Struct_Extention_Enum.Helpers
{
    public static class Extentions

    {
        public static int GetNum(this int num)
        {
            return num;
        }



        public static bool CheckString(this string text, string pattern)
        {

            return Regex.IsMatch(text,pattern);

        }




        public static string IsMarried(this bool isMarried)
        {
            if (isMarried) ;
            return "Evlidir";
            return "Subaydir";
        }

    }



    

}


