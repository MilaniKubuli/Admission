using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            double pointAverage;
            double admissionScore;
            const double minAverage = 3.0;
            const double minScore = 60.0;
            char choice;

            do
            {
                Write("Enter your point average: ");
                pointAverage = double.Parse(ReadLine());
                bool isValidPointScore = false;
                do
                {
                    if (pointAverage < 0 || pointAverage > 4.0)
                    {
                        WriteLine("Invalid point average. Please enter a value between 0 and 4.0.");
                        Write("Enter your point average: ");
                        pointAverage = double.Parse(ReadLine());
                    }
                    else
                    {
                        isValidPointScore = true;
                    }
                }while (!isValidPointScore);

                Write("Enter your admission test score: ");
                admissionScore = double.Parse(ReadLine());
                bool isValidAdmissionScore = false;

                do
                {
                    if (admissionScore < 0 || admissionScore > 100)
                    {
                        WriteLine("Invalid admission score. Please enter a value between 0 and 100.");
                        Write("Enter your admission test score: ");
                        admissionScore = double.Parse(ReadLine());
                    }
                    else
                    {
                        isValidAdmissionScore = true;
                    }
                }while (!isValidAdmissionScore);                                  

                if (pointAverage >= minAverage && admissionScore >= minScore)
                {
                    WriteLine();
                    WriteLine("================================================================");
                    WriteLine("Congratulations, you are eligible for admission.");
                    WriteLine("================================================================");
                    WriteLine();
                }
                else if (pointAverage < minAverage && admissionScore >= 80.00)
                {
                    WriteLine();
                    WriteLine("================================================================");
                    WriteLine("Congratulations, you are eligible for admission.");
                    WriteLine("================================================================");
                    WriteLine();
                }
                else
                {
                    WriteLine();
                    WriteLine("================================================================");
                    WriteLine("We regret to inform you that you are not eligable for admission.");
                    WriteLine("================================================================");
                    WriteLine();
                }

                WriteLine();
                WriteLine("================================================================");
                Write("Do you want to check another student? (Y/N): ");
                choice = char.Parse(ReadLine());
                WriteLine("================================================================");
                WriteLine();

            } while (choice == 'Y' || choice == 'y');

            
            WriteLine("====================Press any key to exit.======================");
           
            ReadKey();
        }
    }
}