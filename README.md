Recipe Management Console Application

This is a console application written in C# for managing recipes. 
It allows users to enter recipe details, display recipes Ingredients, scale Ingredients, 
reset quantities,view or clear all the data they recorded.

To run this application, you need to do the following 

Clone the repository to your local machine
Navigate to the directory containing the application files

Using Visual Studio Locate the application file and open it.


Features

Enter Recipe Details:

This feature allows users to input details of a recipe, including ingredients and steps.
When this option is selected from the main menu, the EnterRecipeDetails() method of the Details class is called.
The user is prompted to enter the number of ingredients.
For each ingredient, the user is prompted to enter the name, quantity, and unit of measurement.
After entering ingredient details, the user is prompted to enter the number of steps.
For each step, the user is prompted to enter a description.
Once all details are entered, they are stored in arrays (ingredients, quantities, units, and steps) within the 
Details class.

Display Recipe:

This feature displays the entered recipe with ingredients and steps.
When this option is selected from the main menu, the DisplayRecipe() method of the Details class is called.
The method retrieves the stored recipe details from the arrays (ingredients, quantities, units, and steps) and
prints them to the console.

Scale Recipe:

This feature scales the quantities of ingredients by a specified factor (e.g., double or triple the recipe).
When this option is selected from the main menu, the ScaleRecipe() method of the Details class is called.
The user is prompted to enter a scaling factor (e.g., 0.5 for half, 2 for double, 3 for triple).
The method multiplies each quantity in the quantities array by the scaling factor, effectively scaling the entire recipe.
Reset Quantities:

This feature resets the quantities of ingredients to their original values.
When this option is selected from the main menu, the ResetQuantities() method of the Details class is called.
This method should implement the logic to reset the quantities of ingredients to their original values. However,
 the implementation is not provided in the code snippet.

Clear All Data:

This feature clears all entered data, including ingredients, quantities, units, and steps.
When this option is selected from the main menu, the ClearAllData() method of the Details class is called.
The method sets all arrays (ingredients, quantities, units, and steps) to null, effectively clearing all stored data.
How to use it 

Choose an option from the main menu by entering the corresponding number.
Follow the prompts to enter recipe details, display recipe, scale recipe, reset quantities, or clear all data.
Repeat steps as needed to manage recipes effectively.
