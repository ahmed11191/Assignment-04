using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Transactions;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter you Num:");
            //int.TryParse(Console.ReadLine(),  out int num);

            //switch (num)
            //{


            //    case int  when num % 3 == 0 && num % 4 == 0:
            //        Console.WriteLine(num +  "\n yes");
            //    break;

            //    default:
            //        Console.WriteLine("no");
            ////        break;
            //}

            #endregion
            #region Q2 


            //    Console.Write("Enter youR number : ");
            // int.TryParse(Console.ReadLine(), out int  num02);




            //string msg02 = num02 switch
            //{
            //    > 0 => "This number is positive",
            //    < 0 => "This number is negative ",
            //    _ => " invalid Number"
            //};
            //Console.WriteLine(msg02);
            #endregion
            #region Q3
            //Console.Write("enter you  Frist_number : ");

            //int.TryParse(Console.ReadLine(), out int fristNumber);

            //Console.Write("enter you second_Number : ");

            //int.TryParse(Console.ReadLine(), out int secondNumber);


            //Console.Write("enter you thrid_Number 3: ");

            //int.TryParse(Console.ReadLine(), out int thridNumber);

            //if (fristNumber > secondNumber && fristNumber > secondNumber)
            //{
            //    Console.WriteLine($"Max is element 1 = {fristNumber}");
            //}
            //else if (secondNumber > thridNumber && secondNumber > thridNumber)
            //{
            //    Console.WriteLine($"Max is element 2 = {secondNumber}");
            //}
            //else if (thridNumber > fristNumber && thridNumber > fristNumber)
            //{
            //    Console.WriteLine($"Max is element 3 = {thridNumber}");
            //}

            //if (fristNumber < secondNumber && fristNumber < thridNumber)
            //{
            //    Console.WriteLine($"Min is element 1= {fristNumber}");
            //}
            //else if (secondNumber < fristNumber && secondNumber < fristNumber)
            //{
            //    Console.WriteLine($"Min is element 2 = {secondNumber}");
            //}
            //else if (thridNumber < fristNumber && thridNumber < secondNumber)
            //{
            //    Console.WriteLine($"Min is element 3 = {thridNumber}");
            //}
            #endregion
            #region Q4
            //Console.Write("Enter your Number: ");
            //int.TryParse(Console.ReadLine(), out int num4);
            //string msg04 = num4 switch
            //{
            //       int when num4 % 2 == 0 => "This Number is Even",

            //      _ => "This Number is Odd"
            //}; 
            //Console.WriteLine(msg04);
            #endregion
            #region Q5
            //Console.Write("Enter you Char :");
            //char ch = Console.ReadKey().KeyChar;

            //string msg05 = ch switch
            //{
            //   'o' or 'e' or 'I' or 'o' or 'u' => " vowel",

            //    _ => "consonant"
            //};

            //Console.WriteLine(msg05);


            #endregion
            #region Q6

            //Console.Write("Enter Num : ");
            //int.TryParse(Console.ReadLine(), out int num6);

            //for (int i = 1; i <= num6; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q7
            // Console.Write("Enter Num : ");
            // int.TryParse(Console.ReadLine(), out int num7);
            // int sum = 0;

            //for (int i = 0; i < 12; i++)
            //{
            //    sum += num7 ;
            //    Console.WriteLine(sum);
            //}
            #endregion
            #region Q8 none
      

        
 
            
                Console.Write("Enter a number: ");
                int.TryParse(Console.ReadLine(), out int number );

                Console.WriteLine($"\nEven numbers between 1 and {number}:");

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                }
            }
     

        #endregion
        #region Q9
        //Console.Write("Enter Num1 : ");
        // double.TryParse(Console.ReadLine(), out double num9);

        //Console.Write("Enter Num2 : ");
        //double.TryParse(Console.ReadLine(), out double num09);

        //double result = Math.Pow(num9, num09);

        //Console.WriteLine(result);


        #endregion
        #region Q10
        //Console.Write("Enter subject1 : ");
        //float.TryParse(Console.ReadLine(),out float sub1);
        //Console.Write("Enter subject2 : ");
        //float.TryParse(Console.ReadLine(), out float sub2);
        //Console.Write("Enter subject3 : ");
        //float.TryParse(Console.ReadLine(), out float sub3);
        //Console.Write("Enter subject4 : ");
        //float.TryParse(Console.ReadLine(), out float sub4);
        //Console.Write("Enter subject5 : ");
        //float.TryParse(Console.ReadLine(), out float sub5);

        //float Total  = 0;
        //float  [] marks =
        //    { sub1,sub2,sub3,sub4,sub5};
        //for (int i = 0; i < marks.Length; i++)
        //{
        //    Total += marks[i];
        //}


        // float? Avg = marks.Average();
        //float? Percentage = ((Total / 500) * 100);
        //Console.WriteLine($"ToTal :{ Total}");
        //Console.WriteLine($"Average : {Avg}");
        //Console.WriteLine($"Percentage: {Percentage}");
        #endregion
        #region Q11
        //Console.Write("Enter Number OF Month:");
        //int.TryParse(Console.ReadLine(), out int NumofMonth);

        //if (NumofMonth == 1 || NumofMonth == 3 || NumofMonth == 5 || NumofMonth == 7
        //    || NumofMonth == 8 || NumofMonth == 10 || NumofMonth == 12)
        //{

        //    Console.WriteLine("Number of Day This Month is : 31");
        //}


        //else if (NumofMonth == 4 || NumofMonth == 6 || NumofMonth == 9 || NumofMonth == 11)
        //{

        //    Console.WriteLine("Number of Day This Month is : 30");
        //}

        //else if (NumofMonth == 2)
        //{

        //    Console.WriteLine("Number of Day This Month is : 28");
        //}

        #endregion
        #region Q12


        //Console.Write("Enter first number: ");
        //double num1 = Convert.ToDouble(Console.ReadLine());


        //Console.Write("Enter an operator (+, -, *, /): ");
        //char op = Console.ReadKey().KeyChar;
        //Console.WriteLine();

        //Console.Write("Enter second number: ");
        //double num2 = Convert.ToDouble(Console.ReadLine());

        //double result;


        //switch (op)
        //{
        //    case '+':
        //        result = num1 + num2;
        //        Console.WriteLine($"Result: {num1} + {num2} = {result}");
        //        break;

        //    case '-':
        //        result = num1 - num2;
        //        Console.WriteLine($"Result: {num1} - {num2} = {result}");
        //        break;

        //    case '*':
        //        result = num1 * num2;
        //        Console.WriteLine($"Result: {num1} * {num2} = {result}");
        //        break;

        //    case '/':

        //        result = num1 / num2;
        //        Console.WriteLine($"Result: {num1} / {num2} = {result}");


        //        break;

        //    default:
        //        Console.WriteLine("Invalid operator!");
        //        break;
        //}


        #endregion
        #region Q13


        #endregion
        #region Q20
        //int[] num0 = { 1, 2, 3, 4, 5, };

        //int Sum = 0;
        //for (int i = 0; i < num01.Length; i++)
        //{

        //    Sum += num01[i];


        //}
        //Console.WriteLine(Sum);
        #endregion
    }
}
}
