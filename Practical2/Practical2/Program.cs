class Practical2
{
    static void Main(string[] args)
    {
        //string str1 = "Hello";
        //string str2 = "World";
        //int number = 2121;
        //int number2 = 134;
        //string strResult = str1 + "" + str2 + number;
        ////string strNumberres = number + number2;// not possible, because int + int should be int
        //string strNumberRes = str1 + (number + number2);   
        //Console.WriteLine(strNumberRes);

        //int modResult = 10 % 3;// 10 - 3 * [10/3] = 10 - 3 * 3 = 10 - 9 = 1
        //int modResult2 = 16 % 7;// 16 - 7 * [16/7] = 16 7* 2 = 16 - 14 = 2
        //Console.WriteLine(modResult);
        //Console.WriteLine(modResult2);
        /////2372467326472398 % 100 ---> the result will be in the range of 0 to 99
        //++modResult;// same as modresult = mosResult +  1;
        //modResult *= 3;// same as modResult = modResult +3; can replace + with / or *
        //double valueDouble = 23.9878;
        //double valueRound = Math.Round(valueDouble++, 2);
        //Console.WriteLine(valueRound);

        //valueRound = Math.Round(++valueDouble, 2);
        //Console.WriteLine(valueRound);
        ////index =-0;
        ///list.betByIndex(index++);
        ///list.getByIndex(index++);

        //bool answer;
        //answer = 13 > 7; //true
        //answer = 19 < 7; //false
        //answer = 13 >= 7; //true
        //answer = 13 > 13; //false
        //answer = 13 >= 13; //true
        //answer = 13 == 13; //true
        //answer = 13 != 13; //false != means NOT Equal to 
        //answer = !true; //false (the oppossite of true)
        //answer = !false; //true (the opposite of false)
        //answer = true && true; //true
        //answer = (13 >= 13) && (13 == 13);//would be the same as true && true

        //answer = true && false;//false
        //answer = false && false; //false

        //double val1 = 23.6543;
        //double val2 = 56.56565;
        //answer = ++val1 == 21 && val2 == 57.56565;//if the first par is false, the second is not executed
        //Console.WriteLine(answer);
        //Console.WriteLine(val1);
        //Console.WriteLine(val2);

        //answer = true || true; //true
        //answer = true || false; //true
        //answer = false || false; //false
        //answer = false || true; //true

        //answer = true && false || false || false;//
        //answer = true && (false || (false || true)); //true
        //////true && (false || (false || true)) -->>true && (false || true)
        /////--->> true && true == true

        //Random rand = new Random();


        //double randomResult = rand.NextDouble();//it returns the random value from 0 to 1
        //int oneToTen = (int) (1 + (randomResult * 10));
        //Console.WriteLine(oneToTen);

        //bool isMorning = true;

        //if (isMorning)
        //{
        //    Console.WriteLine("Wake up!");
        //}

        //string time = Console.ReadLine();
        //if (time == "Morning")
        //{

        //    Console.WriteLine("Good Morning!");
        //}
        //else if (time == "Afternoon")
        //{

        //    Console.WriteLine("Good afternoon!");
        //}

        //else if (time == "Evening")
        //{

        //    Console.WriteLine("Good evening!");
        //}

        //int time = Int32.Parse (Console.ReadLine());
        //if (time >= 5 && time < 9)
        //{
        //    if (time <= 7)
        //    {
        //        Console.WriteLine("Good early morning");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Good morning");
        //    }
        //}


        //else if (time >= 9 && time < 16)
        //{
        //    Console.WriteLine("Good afternoon");
        //    if (time <= 11)
        //    {
        //        Console.WriteLine("Good late morning");
        //    }
        //    else if (time >= 12 && time <= 13)
        //    {
        //        Console.WriteLine("Enjoy your lunch");
        //    }

        //}

        //else if (time < 24 && time >= 0)
        //{

        //    Console.WriteLine("Good evening!");
        //}
        //else
        //{
        //    Console.WriteLine("Input is not valid");
        //}

        //if (true)
        //{
        //    Console.WriteLine("Logic from branch");
        //}

        //string val = "ACD";

        //switch (val)
        //{
        //    case "BCD":
        //        Console.WriteLine("BCD");
        //        break;
        //    case "ACD":
        //        Console.WriteLine("AUY");
        //        break;
        //    default:
        //        Console.WriteLine("Default");
        //        break;
        //}

        bool condition1 = true;
        bool condition2 = false;

        if (condition1)
        {
            Console.WriteLine("Print something");
        }
        else if (condition2)
        {
            Console.WriteLine("Print something more");
        }
        else
        {
            Console.WriteLine("Print something else");
        }


    }


}
