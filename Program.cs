using System;

class Arithmetic
{
    static void Main(string[] args)
    {
        //Addition
        Console.WriteLine("Please provide a number to start addition.");
        string addOneString = Console.ReadLine();
        int addOne = int.Parse(addOneString);

        Console.WriteLine("What number would you like to add to " + addOne + "?");
        string addTwoString = Console.ReadLine();
        int addTwo = int.Parse(addTwoString);

        int addResult = addOne + addTwo;
        Console.WriteLine(addOne + " + " + addTwo + " = " + addResult);

        //Subtraction
        Console.WriteLine("Please provide a number to start subtraction.");
        string subOneString = Console.ReadLine();
        int subOne = int.Parse(subOneString);

        Console.WriteLine("What number would you like to subtract from " + subOne + "?");
        string subTwoString = Console.ReadLine();
        int subTwo = int.Parse(subTwoString);

        int subResult = subOne - subTwo;
        Console.WriteLine(subOne + " - " + subTwo + " = " + subResult);

        //Multiplication
        Console.WriteLine("Please provide a number to start multiplication");
        string multOneString = Console.ReadLine();
        int multOne = int.Parse(multOneString);

        Console.WriteLine("What number would you like to multiply " + multOne + " by?");
        string multTwoString = Console.ReadLine();
        int multTwo = int.Parse(multTwoString);

        int multResult = multOne * multTwo;
        Console.WriteLine(multOne + " * " + multTwo + " = " + multResult);

        //Integer Division
        Console.WriteLine("Please provide a number to start integer division");
        string intOneString = Console.ReadLine();
        int intOne = int.Parse(intOneString);

        Console.WriteLine("What number would you like to divide " + intOne + " by?");
        string intTwoString = Console.ReadLine();
        int intTwo = int.Parse(intTwoString);

        int intResult = intOne / intTwo;
        Console.WriteLine(intOne + " / " + intTwo + " = " + intResult);

        //Decimal Division
        Console.WriteLine("Please provide a number to start decimal division");
        string deciOneString = Console.ReadLine();
        float deciOne = float.Parse(deciOneString);

        Console.WriteLine("What number would you like to divide " + deciOne + " by?");
        string deciTwoString = Console.ReadLine();
        float deciTwo = float.Parse(deciTwoString);

        float deciResult = deciOne / deciTwo;
        Console.WriteLine(deciOne + " / " + deciTwo + " = " + deciResult);

        //Modulus
        Console.WriteLine("Please provide a number to start modulus");
        string modOneString = Console.ReadLine();
        int modOne = int.Parse(modOneString);

        Console.WriteLine("What number would you like to divide " + modOne + " by?");
        string modTwoString = Console.ReadLine();
        int modTwo = int.Parse(modTwoString);

        int modResult = modOne % modTwo;
        Console.WriteLine(modOne + " / " + modTwo + " = " + modResult);
    }
}