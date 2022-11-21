using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

class Practical1
{
    static void Main(string[] args)
    {

        //int valInt = 7;
        //double valDob = valInt;// casting done automatically, because there is no
        ////ptencial data lose
        //Console.WriteLine(valDob);
        //valDob= 10.56;
        //valInt= (int) valDob;//casting done manually, because there is 
        ////potencial data lose
        //Console.WriteLine(valInt);
        //char charVar = 'A';
        //valInt = (int) charVar;
        //Console.WriteLine(valInt);

        //char unicodeVar = '\u0023';
        //Console.WriteLine(unicodeVar);

        //string str = "\u0023";//"\\u0023" extra \ also escapes
        //Console.WriteLine(str);
        //string StrAt = @"\u0023";
        //Console.WriteLine(StrAt);

        //string str1 = "C:\\Users\\madar\\OneDrive\\Documents\\dotnetPractical\\Practical1";//need to use the escape characters 
        //string str2 = @"C:\Users\madar\OneDrive\Documents\dotnetPractical\Practical1";//do not need to use the escape characters


        //Console.WriteLine("Please enter something:");
        //string input = Console.ReadLine();//from VS to Console
        //Console.WriteLine("Please enter something again:");
        //string input2 = Console.ReadLine();
        //string result = input + input2;
        //Console.WriteLine(result);

        // Console.WriteLine("You entered : " + input);
        //Console.WriteLine("You entered : {0}", input);
        Console.WriteLine("Enter number");
        string number1str = Console.ReadLine();
        string number2str = Console.ReadLine();
        int number1 = Int32.Parse(number1str);
        int number2 = Int32.Parse(number2str);
        int result = number1 + number2;
        Console.WriteLine(result);
    }
}
