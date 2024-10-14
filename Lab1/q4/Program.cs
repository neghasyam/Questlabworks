using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            //Console.WriteLine("enter username");
            //string username = Console.ReadLine();
            //Console.WriteLine("Hello " +username);

            //Console.ReadLine();


            //Console.Write("Enter your fullname");
            //string fullname = Console.ReadLine();

            //Console.Write("Enter your age");
            //string age = Console.ReadLine();

            //Console.Write("Enter your favcolor");
            //string favcolor = Console.ReadLine();

            //Console.WriteLine("Hello " + fullname);
            //Console.WriteLine("You are " + age);
            //Console.WriteLine("Your favcolor is " + favcolor);

            //Console.ReadLine();

            //: Temperature Conversion

            ////Console.WriteLine("Enter the temp in cels");
            //double temp;
            //temp= double.Parse(Console.ReadLine());

            //double fahren;
            //fahren= (temp * 9 / 5) + 32;

            //Console.WriteLine($"fahren is {fahren}");
            //Console.ReadLine();



            //5th To calculate P,R,T



            //Console.Write("Enter the prinAmount:");
            //double P;
            //P = double.Parse(Console.ReadLine());

            //Console.Write("Enter the rateofInterest: ");
            //double R;
            //R = double.Parse(Console.ReadLine());

            //Console.Write("Enter the timeinYears): ");
            //double T;
            //T = double.Parse(Console.ReadLine());


            //double simpleInterest;
            //simpleInterest = P * R * T / 100;


            //Console.WriteLine($"The simpleInterest is: {simpleInterest}");
            //Console.ReadLine();



            //6th


            //Console.Write("Enter the radius");

            //double radius= double.Parse(Console.ReadLine());


            //const double PI = 3.14;

            //double area = PI*radius*radius;
            //Console.WriteLine($"The area of circle is: {area}");
            //Console.ReadLine();


            //Lab 7: Input / output with Time Calculation
            //Console.Write("Enter the number of seconds: ");
            //long totalSeconds = Convert.ToInt64(Console.ReadLine());

            //long hours = totalSeconds / 3600;
            //long minutes = (totalSeconds % 3600) / 60;
            //long seconds = totalSeconds % 60;

            //Console.WriteLine($"{totalSeconds} seconds is equivalent to {hours} hours, {minutes} minutes, and {seconds} seconds.");

            //Lab 8: String Length and Character Count
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //int characterCount = 0;

            //foreach (char c in input)
            //{
            //    if (!char.IsWhiteSpace(c))
            //    {
            //        characterCount++;
            //    }
            //}

            //Console.WriteLine($"The number of characters in the string (excluding spaces) is: {characterCount}");


            //9th



            //Console.Write("Enter your weight in kilograms:");
            //double weight = double.Parse(Console.ReadLine());


            //Console.Write("Enter your height in meters: ");
            //double height = double.Parse(Console.ReadLine());

            //double bmi = weight / (height * height);


            //Console.WriteLine($"Your bmi is: {bmi}");
            //Console.ReadLine();



            //11



            //Console.Write("Enter radius of the circle: ");
            //double radius = double.Parse(Console.ReadLine());
            //const double PI = 3.14;
            //double cArea = PI * radius * radius;
            //Console.WriteLine($"The area of the circle is: {cArea}");


            //Console.Write("Enter the length of the rectangle: ");
            //double length = double.Parse(Console.ReadLine());

            //Console.Write("Enter the width of the rectangle: ");
            //double width = double.Parse(Console.ReadLine());

            //double rArea = length * width;
            //Console.WriteLine($"The area of the rectangle is: {rArea}");

            //Console.ReadLine();

            //Lab 12: Using Constants
            //const double PI = 3.14159;
            //const int DAYS_IN_WEEK = 7;

            //Console.Write("Enter the radius of the circle: ");
            //double radius = Convert.ToDouble(Console.ReadLine());

            //// Calculate the circumference
            //double circumference = 2 * PI * radius;

            //// Print the results
            //Console.WriteLine($"The circumference of the circle with radius {radius} is: {circumference}");
            //Console.WriteLine($"There are {DAYS_IN_WEEK} days in a week.");


            //13



            //Console.Write("Enter the width of the rectangle in inches: ");
            //double width = double.Parse(Console.ReadLine());


            //Console.Write("Enter the height of the rectangle in inches: ");
            //double height = double.Parse(Console.ReadLine());
            //double inch_to_cm;


            //double areaInches = width * height;


            //double areaCentimeters = areaInches * (inch_to_cm * inch_to_cm);


            //Console.WriteLine($"The area of the rectangle is: {areaInches} square inches");
            //Console.WriteLine($"The area of the rectangle is: {areaCentimeters} square centimeters");

            //Console.ReadLine();


            //14


            //Console.WriteLine("Enter the first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the third number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //if (num1 >= num2 && num1 >= num3)
            //{
            //    Console.WriteLine("The largest number is: " + num1);
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    Console.WriteLine("The largest number is: " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("The largest number is: " + num3);
            //    Console.ReadLine();
            //}



            ////2nd print using fo rloop 1,3,5 till 11




            //for (int i = 1; i <= 11; i += 2)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();





            //print *




            //Console.WriteLine("Enter the number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.WriteLine("*");
            //    }

            //    Console.WriteLine("*");
            //}
            //Console.ReadLine();




            ////sum of 1st natural numbers




            //int sum = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    sum = sum + i;


            //}
            //Console.WriteLine("The sum of 5 natural numbers is" + sum);
            //Console.ReadLine();




            //print the pattern

            //Console.WriteLine("Enter the number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.WriteLine("*");
            //    }

            //    Console.WriteLine("*");
            //}
            //Console.ReadLine();


            // print 10 20 ....190 continue

            //for (int i = 10; i <= 190; i += 20)
            //{
            //    if (i == 100)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}
            //    Console.ReadLine();



            // print 10 20 ....190 break



            //for (int i = 10; i <= 190; i += 20)
            //{
            //    if (i == 100)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();



            // print odd or even using switch


            //Console.WriteLine("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //switch (n % 2)
            //{
            //    case 0: 
            //        Console.WriteLine($"{n} is even.");
            //        break;
            //    case 1: 
            //        Console.WriteLine($"{n} is odd.");
            //        break;
            //    default: 
            //        Console.WriteLine("Unexpected value.");
            //        break;
            //}


            //Console.ReadLine();


            // find error

            //int[] n = { 1, 2, 3, 4, 5 };
            //for(int i = 0; i < n.Length; i++) 
            //{
            //    Console.WriteLine(n[i]);
            //}
            //Console.ReadLine();



            // Lab 14



            //string name;
            //int age;
            //decimal salary;


            //Console.Write("Enter employee's name: ");
            //Name = Console.ReadLine();


            //Console.Write("Enter employee's age: ");
            //Age = Convert.ToInt32(Console.ReadLine());


            //Console.Write("Enter employee's monthly salary: ");
            //employeeSalary = Convert.ToDecimal(Console.ReadLine());


            //Console.WriteLine("\nEmployee Details:");
            //Console.WriteLine($"Name: {employeeName}");
            //Console.WriteLine($"Age: {employeeAge}");
            //Console.WriteLine($"Monthly Salary: {employeeSalary:C}");


            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey();

            //Lab 15: C# Coding Standards 


            //// Declare two integer variables with descriptive names
            //int firstNumber = 5;
            //int secondNumber = 3;

            //// Calculate the sum of the two numbers
            //int sum = firstNumber + secondNumber;

            //// Output the result to the console
            //Console.WriteLine("The sum of {0} and {1} is: {2}", firstNumber, secondNumber, sum);

            //Lab 16: Assignment Operator

            //// Declare and initialize variables using the assignment operator
            //int age = 25;                  // Assigns the value 25 to the variable age
            //string name = "John";         // Assigns the string "John" to the variable name
            //double height = 5.9;          // Assigns the value 5.9 to the variable height
            //bool isStudent = true;        // Assigns the value true to the variable isStudent

            //// Print the assigned values to the console
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Height: " + height + " feet");
            //Console.WriteLine("Is Student: " + isStudent);

            //Lab 17: Find the Power of a Number
            //// Prompt the user for the base
            //Console.Write("Enter the base number: ");
            //double baseNumber = Convert.ToDouble(Console.ReadLine()); // Read the base number from user input

            //// Prompt the user for the exponent
            //Console.Write("Enter the exponent: ");
            //double exponent = Convert.ToDouble(Console.ReadLine()); // Read the exponent from user input

            //// Calculate the power using Math.Pow()
            //double result = Math.Pow(baseNumber, exponent); // Calculate baseNumber raised to the power of exponent

            //// Display the result
            //Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {result}");

            ////Lab 18: Check Voting Eligibility
            //// Prompt the user for their age
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine()); // Read the age from user input

            //// Prompt the user for their citizenship status
            //Console.Write("Are you a citizen? (yes/no): ");
            //string citizenship = Console.ReadLine().ToLower(); // Read the citizenship status and convert it to lowercase

            //// Check voting eligibility
            //if (age >= 18 && citizenship == "yes")
            //{
            //    Console.WriteLine("You are eligible to vote."); // Eligible message
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote."); // Not eligible message

            //}
            //Console.ReadLine();

            //Lab 19: Determine if a Person is Eligible for a Loan
            //// Prompt the user for their age
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine()); // Read the age from user input

            //// Prompt the user for their annual income
            //Console.Write("Enter your annual income: ");
            //double income = Convert.ToDouble(Console.ReadLine()); // Read the income from user input

            //// Prompt the user for their outstanding loan status
            //Console.Write("Do you have any outstanding loans? (yes/no): ");
            //string loanStatus = Console.ReadLine().ToLower(); // Read the loan status and convert it to lowercase

            //// Check loan eligibility
            //if (age >= 21 && income >= 30000 && loanStatus == "no")
            //{
            //    Console.WriteLine("You are eligible for a loan."); // Eligible message
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for a loan."); // Not eligible message
            //}
            //Console.ReadLine();

            //Lab 20: Eligibility Check
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine()); // Read the age from user input

            //// Prompt the user for their work experience
            //Console.Write("Enter your work experience (in years): ");
            //int workExperience = Convert.ToInt32(Console.ReadLine()); // Read work experience from user input

            //// Prompt the user for college degree status
            //Console.Write("Do you have a college degree? (yes/no): ");
            //string hasCollegeDegree = Console.ReadLine().ToLower(); // Read college degree status and convert to lowercase

            //// Check eligibility
            //bool isAgeEligible = (age >= 18 && age <= 35); // Check age range eligibility
            //bool isExperienceEligible = (workExperience >= 2); // Check work experience eligibility
            //bool hasDegreeOrExperience = (hasCollegeDegree == "yes" || workExperience >= 5); // Check degree or alternative experience

            //// Determine overall eligibility
            //if (isAgeEligible && isExperienceEligible && hasDegreeOrExperience)
            //{
            //    Console.WriteLine("You are eligible to apply for the job."); // Eligible message
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to apply for the job."); // Not eligible message
            //}

            //Lab 21: Check if a Character is a Vowel or Consonant
            //Console.Write("Enter a character: ");
            //char inputChar = Console.ReadLine()[0]; // Read the first character of user input

            //// Convert the character to lowercase for easier comparison
            //char lowerChar = char.ToLower(inputChar);

            //// Check if the character is a vowel
            //bool isVowel = (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' ||
            //                lowerChar == 'o' || lowerChar == 'u');

            //// Determine if it's a vowel or consonant
            //if (char.IsLetter(inputChar)) // Check if the character is a letter
            //{
            //    if (isVowel)
            //    {
            //        Console.WriteLine($"{inputChar} is a vowel."); // Output if it's a vowel
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{inputChar} is a consonant."); // Output if it's a consonant
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid letter."); // Output for invalid input
            //}

            //Lab 22: Check If a Number is Positive, Negative, or Zero
            //Console.Write("Enter a number: ");

            //// Read the input and convert it to a double
            //double number;
            //bool isValid = double.TryParse(Console.ReadLine(), out number); // Try to parse the input

            //// Check if the input is a valid number
            //if (isValid)
            //{
            //    // Determine if the number is positive, negative, or zero
            //    if (number > 0) // Check if the number is positive
            //    {
            //        Console.WriteLine($"{number} is a positive number."); // Output for positive
            //    }
            //    else if (number < 0) // Check if the number is negative
            //    {
            //        Console.WriteLine($"{number} is a negative number."); // Output for negative
            //    }
            //    else // If it's neither, it must be zero
            //    {
            //        Console.WriteLine("The number is zero."); // Output for zero
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number."); // Output for invalid input
            //}
            //Console.ReadLine();

            ////23
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 5 == 0 && number % 11 == 0)
            //{
            //    Console.WriteLine($"{number} is divisible by both 5 and 11.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not divisible by both 5 and 11.");
            //}

            ////24
            //Console.Write("Enter first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter an operator (+, -, *, /): ");
            //char operation = Console.ReadLine()[0];

            //double result;

            //if (operation == '+')
            //{
            //    result = num1 + num2;
            //}
            //else if (operation == '-')
            //{
            //    result = num1 - num2;
            //}
            //else if (operation == '*')
            //{
            //    result = num1 * num2;
            //}
            //else if (operation == '/')
            //{
            //    result = num1 / num2;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator.");
            //    return;
            //}

            //Console.WriteLine($"Result: {result}");

            ////25Lab 25: Grading Syste
            //Console.Write("Enter marks (out of 100): ");
            //int marks = Convert.ToInt32(Console.ReadLine());

            //string grade;

            //if (marks >= 90)
            //{
            //    grade = "A";
            //}
            //else if (marks >= 80)
            //{
            //    grade = "B";
            //}
            //else if (marks >= 70)
            //{
            //    grade = "C";
            //}
            //else if (marks >= 60)
            //{
            //    grade = "D";
            //}
            //else
            //{
            //    grade = "F";
            //}

            //Console.WriteLine($"Grade: {grade}");
            //Console.ReadLine();

            ////26 Swap 2 values
            //Console.Write("Enter first value: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter second value: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //// Swapping using a third variable
            //int temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine($"After swapping: a = {a}, b = {b}");

            ////without using 3rd variable

            //Console.Write("Enter first value: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter second value: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //// Swapping without a third variable
            //a = a + b;
            //b = a - b;
            //a = a - b;

            //Console.WriteLine($"After swapping: a = {a}, b = {b}");

            ////27 Lab 27: Arithmetic Operations 
            //Console.Write("Enter first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"Addition: {num1 + num2}");
            //Console.WriteLine($"Subtraction: {num1 - num2}");
            //Console.WriteLine($"Multiplication: {num1 * num2}");
            //Console.WriteLine($"Division: {num1 / num2}");
            //Console.WriteLine($"Modulus: {num1 % num2}");

            //num1++; // Increment
            //num2--; // Decrement

            //Console.WriteLine($"Incremented first number: {num1}");
            //Console.WriteLine($"Decremented second number: {num2}");

            ////28Avg of 3 nos
            //Console.Write("Enter first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());

            //double average = (num1 + num2 + num3) / 3;

            //Console.WriteLine($"Average: {average:F2}"); // Display average with two decimal places

            ////29Currency conversion
            //Console.Write("Enter amount in USD: ");
            //double amountUSD = Convert.ToDouble(Console.ReadLine());

            //double conversionRate = 0.85; // 1 USD = 0.85 EUR
            //double amountEUR = amountUSD * conversionRate;

            //Console.WriteLine($"Equivalent amount in EUR: {amountEUR}");

            ////30
            //Lab 30: Input is within a range

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number >= 1 && number <= 100)
            //{
            //    Console.WriteLine($"{number} is within the range (1-100).");

            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine($"{number} is even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is odd.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is outside the range (1-100).");
            //}

            ////31
            //Lab 31: Check a number is divisible by 3 & 5

            // Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 5 == 0)
            //{
            //    Console.WriteLine($"{number} is divisible by both 3 and 5.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not divisible by both 3 and 5.");
            //}


            ////32


            //Console.Write("Enter a year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //{
            //    Console.WriteLine($"{year} is a leap year.");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} is not a leap year.");
            //}

            //Console.ReadLine();

            ////33: Check whether a number is positive, even and greater than 50

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 50)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine($"{number} is positive, even, and greater than 50.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is positive and greater than 50, but not even.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not greater than 50.");
            //}

            //Console.ReadLine();

            ////34Calculate studen grade
            //Console.Write("Enter marks for subject 1: ");
            //int marks1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter marks for subject 2: ");
            //int marks2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter marks for subject 3: ");
            //int marks3 = Convert.ToInt32(Console.ReadLine());

            //int passingMark = 40;
            //int totalMarks = marks1 + marks2 + marks3;
            //double average = totalMarks / 3.0;
            //int subjectsFailed = 0;

            //if (marks1 < passingMark) subjectsFailed++;
            //if (marks2 < passingMark) subjectsFailed++;
            //if (marks3 < passingMark) subjectsFailed++;

            //if (subjectsFailed == 0)
            //{
            //    Console.WriteLine("The student has passed in all subjects.");
            //    if (average >= 70)
            //    {
            //        Console.WriteLine("Distinction");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"The student has failed in {subjectsFailed} subjects.");
            //}

            //Console.ReadLine();
            ////35
            //Lab 35: Salary and Tax Calculation
            //Assignment:
            //Write a program that calculates the tax to be paid based on the annual salary of an employee. The
            //tax rules are as follows: 
            //1.If the salary is less than $10,000, no tax is applied.
            //2.If the salary is between $10,000 and $50,000, a 10 % tax is applied.
            //3.If the salary is above $50,000, a 20 % tax is applied.
            //4.If the employee is a senior citizen(aged 60 or above), they get an additional tax
            //exemption of $5,000 from their taxable income.
            //5.Your program should 
            // Prompt the user to enter their annual salary and age. 
            // Use nested if statements to calculate the appropriate tax based on the salary and age.
            // Print the tax amount to be paid.

            //Console.Write("Enter your annual salary: ");
            //double salary = Convert.ToDouble(Console.ReadLine());

            //// Prompt user for age
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //// Initialize tax to be calculated
            //double tax = 0;

            //// Check if the employee is a senior citizen
            //if (age >= 60)
            //{
            //    // Reduce taxable income by $5,000 for senior citizens
            //    salary -= 5000;
            //}

            //// Calculate tax based on the salary brackets
            //if (salary < 10000)
            //{
            //    tax = 0; // No tax applied
            //}
            //else if (salary >= 10000 && salary <= 50000)
            //{
            //    tax = salary * 0.10; // 10% tax
            //}
            //else // salary > 50000
            //{
            //    tax = salary * 0.20; // 20% tax
            //}

            //// Print the tax amount to be paid
            //Console.WriteLine($"Tax to be paid: ${tax:F2}"); // Format tax to two decimal places




        }

    }
}











