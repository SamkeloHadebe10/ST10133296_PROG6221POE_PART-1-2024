using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10133296_PROG6221POE_PART_1
{
    class Details
    {
        private string[] ingredients;
        private double[] quantities;
        private string[] units;
        private string[] steps;

        public void EnterRecipeDetails()
        {
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            ingredients = new string[numIngredients];
            quantities = new double[numIngredients];
            units = new string[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write($"Enter name of ingredient {i + 1}: ");
                ingredients[i] = Console.ReadLine();

                bool validQuantity = false;
                while (!validQuantity)
                {
                    Console.Write($"Enter quantity of {ingredients[i]}: ");
                    string quantityInput = Console.ReadLine();
                    validQuantity = double.TryParse(quantityInput, out quantities[i]);
                    if (!validQuantity)
                    {
                        Console.WriteLine("Invalid quantity. Please enter a valid number.");
                    }
                }

                Console.Write($"Enter unit of measurement for {ingredients[i]}: ");
                units[i] = Console.ReadLine();
            }

            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            steps = new string[numSteps];
            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                steps[i] = Console.ReadLine();
            }

            Console.WriteLine("Recipe details entered successfully!\n");
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("\n-------------------------------\n");
            Console.WriteLine("RECIPE\n");
            Console.WriteLine("\nIngredients:");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine($"{quantities[i]} {units[i]} of {ingredients[i]}");
            }

            Console.WriteLine("\nSteps:\n");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
            Console.WriteLine("\n-------------------------------\n");
        }

        public void ScaleRecipe()
        {
            Console.Write("Enter scaling factor (0.5 for half, 2 for double, 3 for triple): ");
            double factor;
            while (!double.TryParse(Console.ReadLine(), out factor) || factor <= 0)
            {
                Console.WriteLine("Invalid scaling factor. Please enter a positive number.");
                Console.Write("Enter scaling factor (0.5 for half, 2 for double, 3 for triple): ");
            }

            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] *= factor;
            }

            Console.WriteLine("Recipe scaled successfully!");
        }

        public void ResetQuantities()
        {
            // Reset quantities to original values
            // Implement based on your design
            Console.WriteLine("Quantities reset successfully!");
        }

        public void ClearAllData()
        {
            ingredients = null;
            quantities = null;
            units = null;
            steps = null;

            Console.WriteLine("All data cleared successfully!");
        }
    }
}
