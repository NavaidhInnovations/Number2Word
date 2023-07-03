namespace Navaidh.Number2Word;

public class Converter
{
    public static string ConvertToWords(int n)
    {
        if (n < 0)
            return "Minus " + ConvertToWords(-n);
        else if (n == 0)
            return "";
        else if (n <= 19)
            return new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" }[n - 1] + " ";
        else if (n <= 99)
            return new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }[n / 10 - 2] + " " + ConvertToWords(n % 10);
        else if (n <= 199)
            return "One Hundred " + ConvertToWords(n % 100);
        else if (n <= 999)
            return ConvertToWords(n / 100) + "Hundred " + ConvertToWords(n % 100);
        else if (n <= 1999)
            return "One Thousand " + ConvertToWords(n % 1000);
        else if (n <= 999999)
            return ConvertToWords(n / 1000) + "Thousand " + ConvertToWords(n % 1000);
        else if (n <= 1999999)
            return "One Million " + ConvertToWords(n % 1000000);
        else if (n <= 999999999)
            return ConvertToWords(n / 1000000) + "Million " + ConvertToWords(n % 1000000);
        else if (n <= 1999999999)
            return "One Billion " + ConvertToWords(n % 1000000000);
        else
            return ConvertToWords(n / 1000000000) + "Billion " + ConvertToWords(n % 1000000000);
    }
}
