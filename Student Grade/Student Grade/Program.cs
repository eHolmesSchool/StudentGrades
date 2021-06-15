using System;
using System.Collections.Generic;

namespace Student_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> gradeList = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                int grade = rnd.Next(1, 100);
                gradeList.Add(grade);
            }



            Console.WriteLine("Display All Grades");
            Console.WriteLine("Randomize Grades");
            Console.WriteLine("Stats");
            Console.WriteLine("Count Honours");
            Console.WriteLine("Remove Failing");
            Console.WriteLine("Exit");

            string choiceOG = Console.ReadLine();
            //try
            //{
                int choice = Math.Abs(Convert.ToInt32(choiceOG));

                while (choice <= 5 && choice >= 0)
                {
                    int length = gradeList.Count;

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("___________________________________________________________________");
                            for (int i = 0; i < length; i++)
                            {
                                Console.Write(gradeList[i] + "," );
                            }
                            Console.WriteLine(" ");
                            break;

                        case 2:
                            Console.WriteLine("___________________________________________________________________");
                            for (int i = 0; i < length; i++)
                            {
                                int grade = rnd.Next(1, 100);
                                gradeList[i] = grade;
                            }
                            Console.WriteLine("Done");

                            break;

                        case 3:
                            Console.WriteLine("___________________________________________________________________");
                            int highest = 0;
                            int lowest = 99999999;
                            int total = 0;
                            int average;

                            for (int i = 0; i < length; i++)
                            {
                                if (gradeList[i]> highest)
                                {
                                    highest = gradeList[i];
                                }
                            }

                            for (int i = 0; i < length; i++)
                            {
                                if (gradeList[i] < lowest)
                                {
                                    lowest = gradeList[i];
                                }
                            }

                            for (int i = 0; i < length; i++)
                            {
                                total += gradeList[i];
                            }

                            average = total/length;

                            Console.WriteLine("Your Highest score is " + highest);
                            Console.WriteLine("Your Lowest score is " + lowest);
                            Console.WriteLine("Your Average score is " + average);
                            break;

                        case 4:
                            Console.WriteLine("___________________________________________________________________");
                            int honors = 0;
                            for (int i = 0; i < length; i++)
                            {
                                if (gradeList[i] >= 80)
                                {
                                    honors++;
                                }
                            }

                            Console.WriteLine("Your have " + honors + " students with honors");

                            break;


                        case 5:
                            Console.WriteLine("___________________________________________________________________");
                            int failing = 0;
                            for (int i = length-1; i >= 0; i--)
                            {
                                if (gradeList[i] <= 50)
                                {
                                    gradeList.RemoveAt(i);
                                    failing++;
                                }
                            }

                            Console.WriteLine(failing + " students Eliminated");
                            break;

                        default:
                            Console.WriteLine("___________________________________________________________________");

                            Console.WriteLine("Display All Grades");
                            Console.WriteLine("Randomize Grades");
                            Console.WriteLine("Stats");
                            Console.WriteLine("Count Honours");
                            Console.WriteLine("Remove Failing");
                            Console.WriteLine("Exit");
                            break;
                    }
                    Console.WriteLine("___________________________________________________________________");
                    Console.WriteLine("Please enter a number to select another option or press 0(zero) for a reminder of the options");

                    choiceOG = Console.ReadLine();
                    choice = Math.Abs(Convert.ToInt32(choiceOG));
                }
            //}
            //catch { Console.WriteLine("Enter a number next time"); }
        }
    }
}








