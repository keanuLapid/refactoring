using System;
using System.Text;

namespace MaskifyString
{
    public static class StringExtensions
    {
        public static string Maskify(this string str)
        {
            return MaskString(str, '#');
        }

        private static string MaskString(string str, char maskChar)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 5)
                return str;

            StringBuilder sb = new StringBuilder();
            sb.Append(maskChar, str.Length - 4);
            sb.Append(str.Substring(str.Length - 4));

            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4556364607935616".Maskify()); 
            Console.WriteLine("64607935616".Maskify());      
            Console.WriteLine("1".Maskify());               
            Console.WriteLine(string.Empty.Maskify());       
            Console.WriteLine("Skippy".Maskify());           
            Console.WriteLine("Nananananananananananananananana Batman!".Maskify()); 
        }
    }
}