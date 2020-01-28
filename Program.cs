using System;

namespace uwu
{
    class Program
    {
        private static string[] lines = new string[7] {
            "UwU     UwU                   UwU     UwU",
            "UwU     UwU                   UwU     UwU",
            "UwU     UwU                   UwU     UwU",
            "UwU     UwU  UwU         UwU  UwU     UwU",
            "UwU     UwU   UwU  UwU  UwU   UwU     UwU",
            " UwUwUwUwU     UwUwUwUwUwU     UwUwUwUwU ",
            "  UwUwUwU       UwU   UwU       UwUwUwU  "
        };
        static void Main()
        {
            Console.Clear();
            Console.Write("\n");
            foreach (string line in lines)
            {
                Console.Write(centeredString(line, Console.WindowWidth));
            }
        }
        private static string centeredString(string s, int width)
        {
            if (s.Length >= width)
                return s;

            int leftPadding = (width - s.Length) / 2;
            int rightPadding = width - s.Length - leftPadding;

            return (new string(' ', leftPadding) + s + new string(' ', rightPadding));
        }
    }
}
