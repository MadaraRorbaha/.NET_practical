using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Transactions;

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
        //Console.WriteLine("Enter number");
        //string number1str = Console.ReadLine();
        //string number2str = Console.ReadLine();
        //int number1 = Int32.Parse(number1str);
        //int number2 = Int32.Parse(number2str);
        //int result = number1 + number2;
        //Console.WriteLine(result);


        //Console.WriteLine("Enter the first number");
        //string num1 = Console.ReadLine();
        //Console.WriteLine("Enter the second number");
        //string num2 = Console.ReadLine();
        //int number1 = Int32.Parse(num1);
        //int number2 = Int32.Parse(num2);
        //int addition = number1 + number2;
        //Console.WriteLine("Addition: " + addition);
        //int subtraction = number1 - number2;
        //Console.WriteLine("Substraction: " + subtraction);
        //int multipliation = number1 * number2;
        //Console.WriteLine("Multiplication: " + multipliation);
        ////double numb1 = double.Parse(num1);
        ////double numb2 = number2;
        //int division = number2 / number1;
        //Console.WriteLine("Division: " + division);

        Console.WriteLine("Enter number");
        string number1str = Console.ReadLine();

        Console.WriteLine("Enter number2");
        string number2str = Console.ReadLine();

        double number1 = Double.Parse(number1str);
        double number2 = Double.Parse(number2str);

        double resultAdd = number1 + number2;
        Console.WriteLine(number1 + " + " + number2 + " = " + resultAdd);

        double resultSubstr = number1 - number2;
        Console.WriteLine(number1 + " - " + number2 + " = " + resultSubstr);

        double resultDiv = number1 / number2;
        Console.WriteLine(number1 + " / " + number2 + " = " + resultDiv);

        double resultMultip = number1 * number2;
        Console.WriteLine(number1 + " * " + number2 + " = " + resultMultip);

        resultDiv = Math.Round(resultDiv, 2);//round in two decimal places

    }
}
