
using System;
using System.ComponentModel.Design;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            int count = 5;
            char Back;
            int[,] score = new int[count,3];
            int[] students = new int[count];
        menu:;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***** Exam Project *****\n\n");
            Console.WriteLine("1.Enter the number of students");
            Console.WriteLine("2.Average of student's scores");
            Console.WriteLine("3.students highest score and the lowest scores");
            Console.WriteLine("4.Exit");
            selection = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            //########################
            if (selection == 1)
            {
            asking:;
                Console.Write("Please Enter the numbers of students: (it must be between [1 , 5] )");
                count = Convert.ToInt16(Console.ReadLine());
                if (count >5 || count < 1)
                {
                    Console.WriteLine("Error !!");
                    goto asking;
                }
                Console.WriteLine("**************");
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Enter Score number 1 of student {0} ", i + 1);
                    score[i, 0] = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Enter Score number 2 of student {0} ", i + 1);
                    score[i, 1] = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Enter Score number 3 of student {0} ", i + 1);
                    score[i, 2] = Convert.ToInt16(Console.ReadLine());
                }
            top1:;
                Console.Write("Press 'b' to back to main menu :");
                Back = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                if (Back == 'b' || Back == 'B')
                {
                    goto menu;
                }
                else
                {
                    Console.WriteLine("Enter the valid character !!");
                    goto top1;
                }
            }
            //#############################
            else if (selection == 2)
            {
                Console.WriteLine("**************\n");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("The Average of student number {0} is : {1} \n", i + 1, (score[i, 0] + score[i, 1] + score[i, 2]) / 3);
                    Console.WriteLine("*****************\n");
                }
            top2:;
                Console.Write("Press 'b' to back to main menu :");
                Back = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                if (Back == 'b' || Back == 'B')
                {
                    goto menu;
                }
                else
                {
                    Console.WriteLine("Enter the valid character !!");
                    goto top2;
                }

            }
            //#################
            else if(selection == 3)
            {
                int[,] max = new int[count, 3];
                int[,] min = new int[count, 3];
                for (int i = 0;i < count;i++)
                {
                    max[0, 0] = 0;
                    min[0, 0] = 20;
                    for (int j = 0; j < 3; j++)
                    {
                        if (score[i, j] > max[0, 0])
                        {
                            max[0, 0] = score[i, j];
                        }
                        if (score[i,j] < min[0, 0])
                        {
                            min[0 ,0] = score[i, j];
                        }
                    }
                    Console.WriteLine("***************");
                    Console.WriteLine("\nstudent number {0} Highest score is {1} and the lowest score is {2}\n",i+1 , max[0, 0] , min[0, 0]);
                }
            top3:;
                Console.Write("Press 'b' to back to main menu :");
                Back = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                if (Back == 'b' || Back == 'B')
                {
                    goto menu;
                }
                else
                {
                    Console.WriteLine("Enter the valid character !!");
                    goto top3;
                }
            }
            //#####################
            else if (selection == 4)
            {
                Console.WriteLine("Thanks for your attention!!");
            }

        }
    }
}