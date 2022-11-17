using System;
using System.Collections.Specialized;

class SpecialSymvols
{
    string a;
    public static bool operator ==(SpecialSymvols b, string[] eng)
    {
        for (int i = 0; i < eng.Length; i++)
        {
            if(b.a == eng[i])
            {
                return true;
            }
        }
        return false;
    }
    public static bool operator !=(SpecialSymvols b, string[] eng)
    {
        for (int i = 0; i < eng.Length; i++)
        {
            if (b.a == eng[i])
            {
                return false;
            }
        }
        return true;
    }
    public SpecialSymvols(string a)
    {
       this.a = a;
    }
  
}
class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        string[] ENGstrings = { "O", "A", "I", "E", "H", "C", "B", "K", "P", "X", "T", "M" };
        string[] UKRstrings = { "О", "А", "І", "Е", "Н", "С", "В", "К", "Р", "Х", "Т", "М" };
        string a;

        Console.WriteLine("Введіть символ: ");
        a = Console.ReadLine();

        SpecialSymvols symvols = new SpecialSymvols(a);
        if(symvols == ENGstrings || symvols == UKRstrings)
        {
            Console.WriteLine("Схожа за написанням літера є.");
            return;
        }
        else if (symvols != ENGstrings && symvols != UKRstrings)
        {
            Console.WriteLine("Немає схожої за написанням літери.");
            return;
        }

    }
}