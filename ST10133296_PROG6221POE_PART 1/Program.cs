using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace ST10133296_PROG6221POE_PART_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Details details = new Details();
            bool continueLoop = true;

            while (continueLoop)
            {
                Console.WriteLine
                    ("==============================\n" +
                    "" +
                    "1. Enter Recipe Details\n" +
                    "2. Display Recipe\n" +
                    "3. Scale Recipe\n" +
                    "4. Reset Quantities\n" +
                    "5. Clear All Data\n" +
                    "6. Exit\n" +
                    "" +
                    " ==============================" +
                    "");
                

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    details.EnterRecipeDetails();
                }
                else if (choice == 2)
                {
                    details.DisplayRecipe();
                }
                else if (choice == 3)
                {
                    details.ScaleRecipe();
                }
                else if (choice == 4)
                {
                    details.ResetQuantities();
                }
                else if (choice == 5)
                {
                    details.ClearAllData();
                }
                else if (choice == 6)
                {
                    continueLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}


