using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_ladder_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rep;
           
          do
            {
                double a;



                Console.WriteLine("what you want to do :");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("press 1 for addition of two number : ");
                Console.WriteLine(" ");

                Console.WriteLine("press 2 for substraction of two number : ");
                Console.WriteLine(" ");

                Console.WriteLine("press 3 for multiplication of two number : ");
                Console.WriteLine(" ");

                Console.WriteLine("press 4 for division of two number  : ");
                Console.WriteLine(" ");

                Console.WriteLine("press 5 for finding percentage of your exams : ");
                Console.WriteLine(" ");

                Console.WriteLine("press 6 for finding square of a number : ");
                Console.WriteLine(" ");

                Console.WriteLine("press 7 for finding cube of a number : ");
                Console.WriteLine(" ");

                Console.WriteLine("press 8 for finding your age :");
                Console.WriteLine(" ");





                a = Convert.ToDouble(Console.ReadLine());






                if (a == 1)
                {
                    Console.WriteLine("enter 1st number");
                    Console.WriteLine("");

                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("enter 2nd number");
                    Console.WriteLine("");

                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    double add = b + c;

                    Console.WriteLine("Your answer is : " + add);
                    Console.WriteLine("");

                }
                else if (a == 2)

                {
                    Console.WriteLine("enter 1st number");
                    Console.WriteLine("");
                    double z = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("enter 2nd number");
                    Console.WriteLine("");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    double l = z - x;
                    Console.WriteLine("your Ans is : " + l);

                }
                else if (a == 3)
                {

                    Console.WriteLine("enter 1st number");
                    Console.WriteLine("");
                    double s = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" ");

                    Console.WriteLine("enter 2nd number");
                    Console.WriteLine("");
                    double d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("your Ans is : " + s * d);

                }
                else if (a == 4)

                {
                    Console.WriteLine("enter the dividend");
                    Console.WriteLine("");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" ");


                    Console.WriteLine("enter the divisor");
                    Console.WriteLine("");
                    double q = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");
                    if (q > 0)
                    {
                        double s = p / q;

                        Console.WriteLine("your Ans is : " + s);
                    }
                    else
                    {
                        Console.WriteLine("Can't divide by 0 ");
                    }

                }
                else if (a == 5)
                {
                    Console.WriteLine("how many total subject do you have ? i can calculate only 4 and 6 subjects percentage so please enter your response by typing 4 " +
                    "or 6 :)");

                    int j = Convert.ToInt32(Console.ReadLine());

                    if (j == 4)
                    {
                        double per;

                        Console.WriteLine("enter the 1st subject marks");
                        int sub1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("enter the 2nd subject marks");
                        int sub2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("enter the 3rd subject marks");
                        int sub3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("enter the 4th subject marks");
                        int sub4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        int sub5 = sub1 + sub2 + sub3 + sub4;

                        Console.WriteLine("please enter total out of marks :)");

                        int totout = Convert.ToInt32(Console.ReadLine());

                        per = sub5 * 100 / totout;
                        Console.WriteLine("your percentage is : " + per);



                    }
                    else if (j == 6)
                    {
                        Console.WriteLine("enter the 1st subject marks");
                        int sub1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("enter the 2nd subject marks");
                        int sub2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("enter the 3rd subject marks");
                        int sub3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("enter the 4th subject marks");
                        int sub4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("enter the 5th subject marks");
                        int sub5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("enter the 6th subject marks");
                        int sub6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        int tot = sub1 + sub2 + sub3 + sub4 + sub5 + sub6;

                        Console.WriteLine("please enter total out of marks :)");
                        int totout = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        double per6 = tot * 100 / totout;

                        Console.WriteLine("your percentage is : " + per6);


                    }
                    else
                    {
                        Console.WriteLine("you entered invalid number");
                    }

                }
                else if (a == 6)
                { // for finding square 

                    Console.WriteLine("Enter the number you want to square ");
                    Console.WriteLine(" ");

                    double numsq = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");


                    double sqr = numsq * numsq;

                    Console.WriteLine("Your Answer is :  " + sqr);

                }
                else if (a == 7)
                {
                    //finding cube
                    Console.WriteLine("Enter the number you want to cube  ");
                    Console.WriteLine(" ");

                    double numcb = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    double cub = numcb * numcb * numcb;

                    Console.WriteLine("Your Answer is :" + cub);
                }
                else if (a == 8)
                {
                    //finding age 
                    Console.WriteLine("Enter your birth year ");
                    Console.WriteLine(" ");

                    int bir = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("Enter Current year ");
                    Console.WriteLine("");

                    int curyr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    int age = curyr - bir;

                    Console.WriteLine("Your age is : " + age);
                }

                else
                {
                    Console.WriteLine("you entered invalid option  ");
                    
                    
                }

                Console.WriteLine("press 1 for run this program again, Thank you :)");
                Console.WriteLine("");

              rep = Convert.ToInt32(Console.ReadLine());

            } while (rep == 1);
             
             Console.ReadLine();

        
        }
    }
} 
