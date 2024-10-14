using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1]
            //Write a C# program to print the multiplication table of a given number using the for loop.


            //Console.Write("Enter a number ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{n}*{i} = {n * i}");
            //}
            //Console.ReadLine();



            // 2]
            //Write a C# program to display a right-angled triangle pattern using nested for loops.



            //Console.Write("Enter the number of rows");
            //int r = Convert.ToInt32(Console.ReadLine());


            //for (int i = 1; i <= r; i++) //outer loop for rows
            //{

            //    for (int j = 1; j <= i; j++) //inner loop stars
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            //Console.ReadLine();




            //3]
            //Write a C# program to calculate the sum of all even numbers between 1 and 100 using a while loop

            //int sum = 0;
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)  // checking even 
            //    {
            //        sum = sum + i;  // adds to sum
            //    }
            //    i++;  // increment
            //}

            //Console.WriteLine($"The sum is: {sum}");
            //Console.ReadLine();


            //4]
            // Write a C# program to print a multiplication table from 1 to 5 using nested while loops. 


            //int i= 1; 
            //while (i <= 5)
            //{
            //    int j= 1; 

            //    while (j <= 10)
            //    {                   
            //        Console.Write($"{i} * {j} = {i * j}\n");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;

            //}
            //Console.ReadLine();


            //5]
            //Write a C# program to keep asking the user to enter a positive number and print it. The program
            //should stop when the user enters a negative number.




            //while (true)
            //{

            //    Console.Write("Enter a positive number  ");
            //    int n = Convert.ToInt32(Console.ReadLine());


            //    if (n < 0) //check if number is negative
            //    {
            //        Console.WriteLine("Negative number entered exit");
            //        break;  // Exiting the loop
            //    }

            //    Console.WriteLine($"You entered: {n}");//print positive number
            //}


            //Console.ReadLine();


            ////6]
            //Write a C# program to create a basic menu-driven calculator using nested do-while loops. The 
            //calculator should continue to ask the user for two numbers and an operation(+, -, *, /) until the
            //user chooses to exit.
            //int choice;
            //do
            //{

            //    Console.WriteLine("Menu Driven Calculator");
            //    Console.WriteLine("1. Add");
            //    Console.WriteLine("2. Subtract");
            //    Console.WriteLine("3. Multiply");
            //    Console.WriteLine("4. Divide");
            //    Console.WriteLine("5. Exit");
            //    Console.Write("Enter your choice (1-5): ");


            //    choice = Convert.ToInt32(Console.ReadLine());

            //    // If the choice is between 1 and 4, prompt for numbers
            //    if (choice >= 1 && choice <= 4)
            //    {
            //        Console.Write("Enter the first number: ");
            //        double num1 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Enter the second number: ");
            //        double num2 = Convert.ToDouble(Console.ReadLine());

            //        // Perform the selected operation using a switch case
            //        switch (choice)
            //        {
            //            case 1:
            //                Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
            //                break;
            //            case 2:
            //                Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
            //                break;
            //            case 3:
            //                Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
            //                break;
            //            case 4:
            //                if (num2 != 0)
            //                {
            //                    Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Error: Division by zero is not allowed!");
            //                }
            //                break;
            //        }
            //    }
            //    else if (choice != 5)
            //    {
            //        Console.WriteLine("Invalid choice, please select a valid option.");
            //    }

            //    Console.WriteLine();

            //} while (choice != 5);  // Repeat until the user chooses to exit 

            //Console.WriteLine("Exiting the calculator. Thank you!");
            //Console.ReadLine();

            //7]

            //Write a C# program to print all numbers from 1 to 100. Use the continue statement to skip 
            //numbers that are divisible by 3, and use the break statement to stop the loop if the number
            //exceeds 50.



            //for (int i = 1; i <= 100; i++)
            //{

            //    if (i % 3 == 0)
            //    {
            //        continue; //using to skip numbers div by 3
            //    }
            //    else if (i > 50)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.ReadLine();

            //8]
            //Write a C# program to calculate the sum of all odd numbers between 1 and 100 using a for loop.


            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{

            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }


            //}
            //Console.WriteLine($"The sum of odd numbers is {sum}");
            //Console.ReadLine();

            //9]
            //Write a C# program to calculate the factorial of a given number using a while loop. 

            //Console.WriteLine("enter a number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //int i = n;
            //while (i > 1)
            //{
            //    factorial *= i;
            //    i--;
            //}
            //Console.WriteLine($"The factorial of {n} is {factorial}");
            //Console.ReadLine();







            //10]
            //Write a C# program to print a number pyramid using a nested while loop. Example for 5 rows: 
            //1
            //2 2          
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5






            //int rows = 5; // Specify the number of rows for the pyramid
            //int i = 1; // Counter for the current row

            //while (i <= rows)
            //{
            //    int j = 1; // Counter for the current number in the row
            //    while (j <= i)
            //    {
            //        Console.Write(i + " "); // Print the current row number
            //        j++; // Increment the number 
            //    }
            //    Console.WriteLine(); // Move to the next line after finishing the current row
            //    i++; // Increment the row 
            //}
            //Console.ReadLine();





            //13]
            //Write a C# program that accepts a number from the user and calculates the sum of its digits using 
            //a do -while loop.







            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0; // Variable to hold the sum of digits
            //int originalNumber = n; // Store the original number for display


            //do
            //{
            //    int digit = n % 10; // Get the last digit
            //    sum += digit; // Add the digit to the sum
            //    n /= 10; // Remove the last digit from the number
            //}


            //while (n > 0); // Continue until there are no digits left

            //Console.WriteLine($"The sum of the digits of {originalNumber} is: {sum}");
            //Console.ReadLine();





            //14]
            //Write a C# program that accepts 10 numbers from the user and finds the largest number using a 
            //for loop.






            //int largestNumber = int.MinValue;

            //Console.WriteLine("Enter 10 numbers:");


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"Number {i + 1}: ");

            //    int currentNumber = int.Parse(Console.ReadLine()); // Read the current number


            //    if (currentNumber > largestNumber)
            //    {
            //        largestNumber = currentNumber;
            //    }
            //}

            //Console.WriteLine($"The largest number is: {largestNumber}");
            //Console.ReadLine();





            ////15]
            //Write a C# program to calculate the sum of squares of all numbers from 1 to a user-provided 
            //number using a while loop.




            //Console.Write("Enter a number");
            //int number = int.Parse(Console.ReadLine()); 
            //int sumOfSquares = 0; // Variable to hold the sum of squares
            //int i = 1; // Initialize the counter


            //while (i <= number)
            //{
            //    sumOfSquares += i * i; // Add the square of the current number to the sum
            //    i++; // Increment the counter
            //}

            //Console.WriteLine($"The sum of squares from 1 to {number} is: {sumOfSquares}"); 
            //Console.ReadLine();


            //11]Lab 11: Guess the Number Game
            //Assignment:
            //    Write a C# program that generates a random number between 1 and 100. The user has to guess 
            //     the number, and the program should give hints("too high" or "too low") until the user guesses
            //      correctly.Use a nested do -while loop to allow the user to play multiple rounds. 
            //     Random random = new Random();
            //int numberToGuess, userGuess;
            //string playAgain;

            //do
            //{
            //    // Generate a random number between 1 and 100
            //    numberToGuess = random.Next(1, 101);
            //    userGuess = 0;

            //    Console.WriteLine("Guess the number between 1 and 100!");

            //    do
            //    {
            //        Console.Write("Enter your guess: ");
            //        userGuess = Convert.ToInt32(Console.ReadLine());

            //        if (userGuess > numberToGuess)
            //        {
            //            Console.WriteLine("Too high! Try again.");
            //        }
            //        else if (userGuess < numberToGuess)
            //        {
            //            Console.WriteLine("Too low! Try again.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Congratulations! You guessed the number!");
            //        }

            //    } while (userGuess != numberToGuess); // Repeat until the user guesses correctly

            //    // Ask if the user wants to play again
            //    Console.Write("Do you want to play again? (yes/no): ");
            //    playAgain = Console.ReadLine().ToLower();

            //} while (playAgain == "yes"); // Repeat for another round if the user says yes

            //Console.WriteLine("Thank you for playing! Goodbye!");
            //Console.ReadLine();

            //12]Lab 12: Simple Calculator
            //  Assignment:
            //Write a C# program to create a simple calculator using a switch-case statement. The program 
            // should handle addition, subtraction, multiplication, and division.

            //do
            //{
            //    // Get the first number
            //    Console.Write("Enter the first number: ");
            //    num1 = Convert.ToDouble(Console.ReadLine());

            //    // Get the second number
            //    Console.Write("Enter the second number: ");
            //    num2 = Convert.ToDouble(Console.ReadLine());

            //    // Get the operation
            //    Console.Write("Choose an operation (+, -, *, /): ");
            //    operation = Convert.ToChar(Console.ReadLine());

            //    // Perform the operation using a switch-case statement
            //    switch (operation)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            Console.WriteLine($"Result: {num1} + {num2} = {result}");
            //            break;
            //        case '-':
            //            result = num1 - num2;
            //            Console.WriteLine($"Result: {num1} - {num2} = {result}");
            //            break;
            //        case '*':
            //            result = num1 * num2;
            //            Console.WriteLine($"Result: {num1} * {num2} = {result}");
            //            break;
            //        case '/':
            //            if (num2 != 0)
            //            {
            //                result = num1 / num2;
            //                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Division by zero is not allowed!");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operation. Please try again.");
            //            break;
            //    }

            //    // Ask if the user wants to perform another calculation
            //    Console.Write("Do you want to perform another calculation? (yes/no): ");
            //    continueCalculation = Console.ReadLine().ToLower();

            //} while (continueCalculation == "yes"); // Repeat if the user says yes

            //Console.WriteLine("Thank you for using the calculator! Goodbye!");
            ////Console.ReadLine();

            //Lab 16: Countdown Time
            //    int countdown = 10;

            //do
            //{
            //    Console.WriteLine(countdown);
            //    countdown--;
            //    System.Threading.Thread.Sleep(1000); // Wait for 1 second
            //} while (countdown > 0);

            //Console.WriteLine("Countdown complete!");
            //Console.ReadLine();
            //Lab 17: Finding the First Multiple of 5
            //    int[] numbers = { 1, 3, 4, 7, 10, 12, 15 };

            //foreach (int number in numbers)
            //{
            //    if (number % 5 == 0)
            //    {
            //        Console.WriteLine($"The first multiple of 5 is: {number}");
            //        break;
            //    }
            //}
            //Console.ReadLine();

            //Lab 18: Print Non-Multiples of 3

            //    for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue; // Skip multiples of 3
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //    Lab 19: Checking for Palindrome
            //        Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //    int originalNumber = number;
            //    int reversedNumber = 0;

            //    while (number > 0)
            //    {
            //        int digit = number % 10;
            //        reversedNumber = reversedNumber * 10 + digit;
            //        number /= 10;
            //    }

            //    if (originalNumber == reversedNumber)
            //    {
            //        Console.WriteLine($"{originalNumber} is a palindrome.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{originalNumber} is not a palindrome.");
            //    }
            //    Console.ReadLine();

            //    Lab 20: Average of Positive Numbers
            //        double sum = 0;
            //    int count = 0;
            //    double number;

            //    do
            //    {
            //        Console.Write("Enter a positive number (negative to quit): ");
            //        number = Convert.ToDouble(Console.ReadLine());

            //        if (number >= 0)
            //        {
            //            sum += number;
            //            count++;
            //        }
            //    } while (number >= 0);

            //    if (count > 0)
            //    {
            //        double average = sum / count;
            //        Console.WriteLine($"The average of the entered positive numbers is: {average}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No positive numbers were entered.");
            //    }
            //    Console.ReadLine();

            //    Lab 21: Reverse a Number
            //         Console.Write("Enter a number to reverse: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    int reversedNumber = 0;

            //    do
            //    {
            //        int digit = number % 10;
            //        reversedNumber = reversedNumber * 10 + digit;
            //        number /= 10;
            //    } while (number > 0);

            //    Console.WriteLine($"Reversed number is: {reversedNumber}");

            //    Lab 22: Menu - Driven String Operations
            //        string inputString;
            //    char choice;

            //    Console.Write("Enter a string: ");
            //    inputString = Console.ReadLine();

            //    do
            //    {
            //        Console.WriteLine("\nMenu:");
            //        Console.WriteLine("1. Reverse the string");
            //        Console.WriteLine("2. Convert to uppercase");
            //        Console.WriteLine("3. Convert to lowercase");
            //        Console.WriteLine("4. Find the length of the string");
            //        Console.WriteLine("5. Exit");
            //        Console.Write("Enter your choice (1-5): ");
            //        choice = Convert.ToChar(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case '1':
            //                char[] charArray = inputString.ToCharArray();
            //                Array.Reverse(charArray);
            //                Console.WriteLine($"Reversed string: {new string(charArray)}");
            //                break;
            //            case '2':
            //                Console.WriteLine($"Uppercase: {inputString.ToUpper()}");
            //                break;
            //            case '3':
            //                Console.WriteLine($"Lowercase: {inputString.ToLower()}");
            //                break;
            //            case '4':
            //                Console.WriteLine($"Length of the string: {inputString.Length}");
            //                break;
            //            case '5':
            //                Console.WriteLine("Exiting...");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid choice! Please try again.");
            //                break;
            //        }
            //    } while (choice != '5');
            //    Console.ReadLine();
            //Lab 23: Skip Multiples of 4
            //    for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        continue; // Skip multiples of 4
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            //Lab 24: Fibonacci Sequence
            //    int n1 = 0, n2 = 1, n3;

            //Console.WriteLine("Fibonacci Sequence:");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(n1 + " ");
            //    n3 = n1 + n2;
            //    n1 = n2;
            //    n2 = n3;
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //Lab 25: Find All Armstrong Numbers

            //    Console.WriteLine("Armstrong numbers between 1 and 500:");

            //int number = 1;
            //while (number <= 500)
            //{
            //    int sum = 0, temp = number;

            //    while (temp > 0)
            //    {
            //        int digit = temp % 10;
            //        sum += digit * digit * digit; // Calculate the cube of the digit
            //        temp /= 10;
            //    }

            //    if (sum == number)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    number++;
            //}

            //Lab 26: Menu - Driven Number System Conversion
            //Assignment: 
            //Write a C# program to create a menu-driven system for number conversions: 
            //1.Binary to Decimal
            //2.Decimal to Binary
            //3.Decimal to Hexadecimal
            //Use a switch-case statement to implement this.

            //        int choice;
            //    do
            //    {
            //        Console.WriteLine("\nMenu:");
            //        Console.WriteLine("1. Binary to Decimal");
            //        Console.WriteLine("2. Decimal to Binary");
            //        Console.WriteLine("3. Decimal to Hexadecimal");
            //        Console.WriteLine("4. Exit");
            //        Console.Write("Enter your choice (1-4): ");
            //        choice = Convert.ToInt32(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case 1:
            //                Console.Write("Enter a binary number: ");
            //                string binary = Console.ReadLine();
            //                int decimalNumber = Convert.ToInt32(binary, 2);
            //                Console.WriteLine($"Decimal: {decimalNumber}");
            //                break;
            //            case 2:
            //                Console.Write("Enter a decimal number: ");
            //                int decimalToConvert = Convert.ToInt32(Console.ReadLine());
            //                string binaryResult = Convert.ToString(decimalToConvert, 2);
            //                Console.WriteLine($"Binary: {binaryResult}");
            //                break;
            //            case 3:
            //                Console.Write("Enter a decimal number: ");
            //                int decimalForHex = Convert.ToInt32(Console.ReadLine());
            //                string hexResult = Convert.ToString(decimalForHex, 16).ToUpper();
            //                Console.WriteLine($"Hexadecimal: {hexResult}");
            //                break;
            //            case 4:
            //                Console.WriteLine("Exiting...");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid choice! Please try again.");
            //                break;
            //        }
            //    } while (choice != 4);

            //Lab 27: Reverse a String

            //  Console.Write("Enter a string to reverse: ");
            //  string inputString = Console.ReadLine();
            //  string reversedString = "";

            //  for (int i = inputString.Length - 1; i >= 0; i--)
            //  {
            //      reversedString += inputString[i];
            //  }

            //  Console.WriteLine($"Reversed string: {reversedString}");

            //            Lab 28: Count Vowels and Consonants in a String
            //                Console.Write("Enter a string: ");
            //            string inputString = Console.ReadLine();
            //            int vowels = 0, consonants = 0;

            //            foreach (char c in inputString)
            //            {
            //                if (char.IsLetter(c))
            //                {
            //                    if ("AEIOUaeiou".IndexOf(c) >= 0)
            //                    {
            //                        vowels++;
            //                    }
            //                    else
            //                    {
            //                        consonants++;
            //                    }
            //                }
            //            }

            //            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");

            
            //            Lab 29: Find Maximum and Minimum

            //                int max = int.MinValue;
            //            int min = int.MaxValue;

            //            Console.WriteLine("Enter 5 numbers:");

            //            for (int i = 0; i < 5; i++)
            //            {
            //                Console.Write($"Number {i + 1}: ");
            //                int number = Convert.ToInt32(Console.ReadLine());

            //                if (number > max)
            //                {
            //                    max = number; // Update max if the current number is greater
            //                }

            //                if (number < min)
            //                {
            //                    min = number; // Update min if the current number is lesser
            //                }
            //            }

            //            Console.WriteLine($"Maximum number: {max}");
            //            Console.WriteLine($"Minimum number: {min}");

            
            //            Lab 30: Count Digits of a Number

            //                Console.Write("Enter a number: ");
            //            int number = Convert.ToInt32(Console.ReadLine());
            //            int count = 0;

            //            // Handle negative numbers
            //            if (number < 0)
            //            {
            //                number = -number; // Convert to positive for counting digits
            //            }

            //            // Count the number of digits
            //            while (number > 0)
            //            {
            //                number /= 10; // Remove the last digit
            //                count++; // Increment the count
            //            }

            //            // Special case for 0
            //            if (count == 0)
            //            {
            //                count = 1; // 0 has one digit
            //            }

            //            Console.WriteLine($"The number of digits is: {count}");






        }

    }

}
