/* This program is a basic aritmethic menu.

- The interface is a menu of console which shows five options. The first option is the sum,
the second is the substraction, the third option is the multiplication, the fourth option
is the division and the fifth option is to exit of the program.

- At the bottom of the menu, the program asks to a option (Select an option: ), to answer this 
request, the user have to write by keyboard the name of aritmethic operation in English or the 
word "exit", it could be lowercase or uppercase, also with or without  spaces on the sides.

- When the user write a aritmethic operation and press the key enter, the program asks to 
the user for three values (float), so the user have to introduce the values to continue the 
flow of the program. Then the program makes the operations and it shows the result. 
Finaly, shows a message that asks to the user press the key enter to return to the principal menu. 

- If the user write exit by keyboard, the program will stop and close the window.
*/

using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

class aritmethic
{
    // Method that shows the principal menu of the application
    public static void Menu()
    {
        Console.Write("".PadLeft(25, '-'));
        Console.Write(" Aritmethic menu ");
        Console.WriteLine("".PadRight(25, '-'));
        Console.WriteLine();
        Console.WriteLine("-- Option 1: Sum");
        Console.WriteLine("-- Option 2: Substraction");
        Console.WriteLine("-- Option 3: Multiplation");
        Console.WriteLine("-- Option 4: Division");
        Console.WriteLine("-- Option 5: Exit");
        Console.WriteLine("".PadRight(66, '-'));
    }

    // Method that receive the kind of operation and ask for the values to the user
    public static float Operations(string op)
    {
        float d1 = 0.0f, d2 = 0.0f, d3 = 0.0f, result = 0.0f;

        Console.Write("Introduce the first value: ");
        d1 = float.Parse(Console.ReadLine());
        Console.Write("Introduce the second value: ");
        d2 = float.Parse(Console.ReadLine());
        Console.Write("Introduce the third value: ");
        d3 = float.Parse(Console.ReadLine());

        switch (op)
        {
            case "sum":
                result = d1 + d2 + d3;
                break;

            case "substraction":
                result = d1 - d2 - d3;
                break;

            case "multiplication":
                result = d1 * d2 * d3;
                break;

            case "division":
                result = (d1 / d2) / d3;
                break;
        }

        return result;
    }
    public static void Main()
    {
        float result = 0.0f;
        string? option = null;

        do
        {
            aritmethic.Menu();
            Console.Write("Select a option: ");
            option = Console.ReadLine();
            option = option.ToLower().Trim();
            Console.Clear();


            if (option == "exit")
            {
                Console.WriteLine("Good bye :)");
                Console.Write("Press enter key to exit...");
                Console.ReadLine();
            }
            else if (option == "sum" || option == "subtraction" || option == "multiplication" || option == "division")
            {
                result = aritmethic.Operations(option);
                Console.WriteLine($"The result of the {option} is: {result}");
                Console.Write("Press enter key to retun to principal menu...");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Error: the option is not valid");
                Console.Write("Press enter key to retun to principal menu...");
                Console.ReadLine();
                Console.Clear();
            }

        } while (option != "exit");
    }
}