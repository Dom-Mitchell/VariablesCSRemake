using System;

namespace VariablesCSRemake
{
  class Program
  {
    static void CoffeeData()
    {
      // Declare variables and assign values to them.
      // Demonstrating use of the correct data type for each variable.
      var numberOfCupsOfCoffee = 3;
      var fullName = "John Doe";
      // Updated DateTime format to be more readable and user friendly.
      var today = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
      Console.WriteLine($"Hello, {fullName}! You have had {numberOfCupsOfCoffee} cups of coffee on {today}.\n");
    }

    static void Greeting()
    {
      // Print the values of the variables to the console.
      // Demonstrating string interpolation to include variables in the output.
      Console.WriteLine("What is your name?");
      var userName = Console.ReadLine();

      // Check to see if the user is Alice and respond accordingly.
      if (userName == "Alice" || userName == "alice")
      {
        // Personalized greeting for Alice.
        Console.WriteLine("Welcome back, Alice! It's great to see you again. How was Wonderland?\n");
      }
      // Check if the user entered a name and respond accordingly.
      else if (string.IsNullOrEmpty(userName))
      {
        // Prompt the user to enter a name if they didn't provide one.
        Console.WriteLine("Hello! It seems like you didn't enter a name. Please try again.");
        userName = Console.ReadLine();
      }
      // General greeting for all other users.
      else
      {
        Console.WriteLine($"Hello, {userName}! You have a great name.\n");
      }


      // Prompt the user for two numbers.
      Console.WriteLine("What is your favorite number?");
      var firstNumberAsString = Console.ReadLine();
      // Convert the string input to a double for arithmetic operations.
      var firstOperand = double.Parse(firstNumberAsString);

      Console.WriteLine("What is another number?");
      var secondNumberAsString = Console.ReadLine();
      // Convert the second string input to a double.
      var secondOperand = double.Parse(secondNumberAsString);

      // Perform basic arithmetic operations and display the results.
      // Declare variables for the results of arithmetic operations.
      var sum = firstOperand + secondOperand;
      var difference = firstOperand - secondOperand;
      var product = firstOperand * secondOperand;
      var quotient = firstOperand / secondOperand;
      var remainder = firstOperand % secondOperand;

      // Display the results of the arithmetic operations.
      Console.WriteLine($"Those 2 numbers added together is {sum} and subtracted is {difference}.");
      Console.WriteLine($"Those 2 numbers multiplied is {product} and divided is {quotient} with a remainder of {remainder}.");
    }

    static void Main(string[] args)
    {
      // Call the CoffeeData method to display coffee data.
      CoffeeData();

      // Call the Greeting method to interact with the user.
      Greeting();

    }
  }
}
