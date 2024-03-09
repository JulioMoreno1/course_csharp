/* This program is a basic aritmethic menu.

- The interface is a menu of console which shows six options. The first option is the sum,
the second is the substraction, the third option is the multiplication, the fourth option
is the division, the fifth option is a combination about the privious operations and the sixth 
option is to exit of the program.

- At the bottom of the menu, the program asks to a option (Select an option: ), to answer this 
request, the user have to write by keyboard the name of aritmethic operation in English or the 
word "exit", it could be lowercase or uppercase, also with or without  spaces on the sides.

- When the user write a aritmethic operation or combination of operations and the press the key 
enter, the program asks to the user for three values (float), so the user have to introduce the
values to continue the flow of the program. Then the program makes the operations and it 
shows the result. Finaly, shows a message that asks to the user press the key enter to return 
to the principal menu. 

- If the user write exit by keyboard, the program will stop and close the window.
*/

using System;
using System.ComponentModel.Design;

class aritmethic
{
    public static void menu()
    {
        Console.Write("".PadLeft(25, '-'));
        Console.Write(" Aritmethic menu ");
        Console.WriteLine("".PadRight(25, '-'));
        Console.WriteLine();
        Console.WriteLine("-- Option 1: Sum");
        Console.WriteLine("-- Option 2: Substraction");
        Console.WriteLine("-- Option 3: Multiplation");
        Console.WriteLine("-- Option 4: Division");
        Console.WriteLine("-- Option 5: Combine operations");
        Console.WriteLine("-- Option 6: Exit");
        Console.WriteLine("".PadRight(66, '-'));
    }
    public static void Main()
    {
        float data1 = 0.0f, data2 = 0.0f, data3 = 0.0f;
        string? option = null;

        do
        {
            aritmethic.menu();
            Console.Write("Select a option: ");
            option = Console.ReadLine();
            option = option.ToLower().Trim();
        } while (option != "exit");
    }
}