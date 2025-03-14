﻿// Create a new instance of Calculator with a greeting message and start the calculator
Calculator calculator = new("Welcome to Richard Cool Calculator!");
calculator.Start();

public class Calculator
{
    private string _greeting;

    // Constructor to initialize the greeting message
    public Calculator(string greeting)
    {
        _greeting = greeting;
    }

    // Method to start the calculator
    public void Start()
    {
        // Print the greeting message to the console
        Console.WriteLine(_greeting);

        // Dictionary now supports 4 basic operations
        var supportedOperators = new Dictionary<string, string>
        {
            { "+", "Add" },
            { "-", "Subtract" },
            { "*", "Multiply" },
            { "/", "Divide" }
        };

        // dictionary for user prompts
        var userPrompts = new Dictionary<string, string>
        {
            { "y", "yes" },
            { "n", "no" }
        };

        // Infinite loop to keep the calculator running
        while (true)
        {
            // Display available operator choices
            Console.WriteLine("Operator choices are as follows:");
            foreach (var op in supportedOperators)
            {
                Console.WriteLine($"{op.Value}: {op.Key}");
            }

            // Prompt the user to enter an operator
            Console.WriteLine("Enter an operator:");
            string operatorChoice = Console.ReadLine();

            // Validate the entered operator
            if (!supportedOperators.TryGetValue(operatorChoice, out var selectedOperatorDescription))
            {
                Console.WriteLine("Invalid operator choice.");
                continue;
            }

            // Display the selected operator
            Console.WriteLine($"You selected: {selectedOperatorDescription}");
            Console.WriteLine();

            // Remind the user about the range of integer values
            Console.WriteLine($"Recall that integers are in the range {int.MinValue} to {int.MaxValue}!");
            Console.WriteLine();

            // Prompt the user to enter the first integer
            Console.WriteLine("Enter the first integer:");
            string firstNumberInput = Console.ReadLine();
            if (!int.TryParse(firstNumberInput, out int firstNumber))
            {
                // Display an error message if the input is not a valid integer
                Console.WriteLine($"{firstNumberInput} could not be parsed as an integer!");
                continue;
            }
            int firstNumberForFractionResult = firstNumber;

            // Prompt the user to enter the second integer
            Console.WriteLine("Enter the second integer:");
            string secondNumberInput = Console.ReadLine();
            if (!int.TryParse(secondNumberInput, out int secondNumber))
            {
                // Display an error message if the input is not a valid integer
                Console.WriteLine($"{secondNumberInput} could not be parsed as an integer!");
                continue;
            }
            int secondNumberForFractionResult = secondNumber;

            //TODO:
            // create check for division operation where divisor > dividend
            // create prompt for ?continue and calculate as decimal fraction?
            bool quotientIsFraction = false;
            if (operatorChoice == "/" && firstNumber <  secondNumber)
            {
                quotientIsFraction = true;
                Console.WriteLine($"The divisor you entered ({secondNumber}) is larger than the dividend you entered({firstNumber})");
            }


            // Create the logic for finding the correct result of division along with a remainder
            bool resultHasRemainder = false;
            int remainder = 0;
            if (operatorChoice == "/" && firstNumber % secondNumber != 0)
            {
                remainder = firstNumber % secondNumber;
                firstNumber -= remainder;
                resultHasRemainder = true;
            }

            int result;
            double quotientWithFraction;
            try
            {
                // Perform the arithmetic operation based on the chosen operator
                result = operatorChoice switch
                {
                    "+" => firstNumber + secondNumber,
                    "-" => firstNumber - secondNumber,
                    "*" => firstNumber * secondNumber,
                    "/" => firstNumber / secondNumber,
                    _ => throw new NotSupportedException($"Arithmetic is not currently supported for operator {operatorChoice}.")
                };
            }
            catch (DivideByZeroException)
            {
                // Handle division by zero exception
                Console.WriteLine("You cannot divide by zero.");
                continue;
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"There was an unhandled exception: {ex.Message}");
                continue;
            }

            // Display the result or result with a remainder
            Console.WriteLine(resultHasRemainder? $"The result is: {result} with a remainder of {remainder}" : $"The result is: {result}");

            // TODO: create prompt and logic for calculating result w/ any decimals
            if (resultHasRemainder || quotientIsFraction)
            {
                Console.WriteLine("Would you like to see the result as a decimal?\nEnter y for YES or n for NO:");
                string decimalPreference = Console.ReadLine();
                if (!userPrompts.TryGetValue(decimalPreference, out var selectedPreference))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }
                //Console.WriteLine(selectedPreference);
                //if (selectedPreference != null)
                //{
                //    Console.WriteLine("now we're cooking");
                //}
                if (selectedPreference == "yes")
                {
                    quotientWithFraction = (double)firstNumberForFractionResult / (double)secondNumberForFractionResult;
                    Console.WriteLine($"The result as a decimal is: {quotientWithFraction}");
                }
            }
        }
    }
}
