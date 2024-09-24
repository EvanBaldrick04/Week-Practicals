//firstTask();
//secondTask();
//thirdTask();
fourthTask();
//fifthTask();

void firstTask()
{
    Console.WriteLine("Please enter your name");
    string name = Console.ReadLine();

    Console.WriteLine("Please enter your age");
    int age = Convert.ToInt32(Console.ReadLine()) + 5;

    Console.WriteLine("Hello {0}, you will be {1} in 5 years", name, age);


}

void secondTask()
{
    Console.WriteLine("Please enter your age");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age >=0 && age < 13)
    {
        Console.WriteLine("You are a child");
    }
    else if (age >= 13 && age <= 19 )
    {
         Console.WriteLine("You are a teenager");
    }
    else if (age >= 20 && age < 110 )
    {
        Console.WriteLine("You are an adult");
    }
    else
    {
        Console.WriteLine("Age is outside valid range, cannot be less than 0 or greater than 110");
    }
}

void thirdTask()
{
    Console.WriteLine("Enter a number to see if its positive, negative, or zero.");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num < 0)
    {
        Console.WriteLine("number is a negative");
    }
    else if (num > 0)
    {
        Console.WriteLine("number is positive");
    }
    else
    {
        Console.WriteLine("Your number is zero");
    }
}

void fourthTask()
{
    Console.WriteLine("Enter year");
    int year = Convert.ToInt32(Console.ReadLine());

    if (year % 4 == 0 && year % 100 != 0)
    {
        Console.Write("this year is a leap year");
    }
    else if (year % 400 == 0)
    {
        Console.WriteLine("this year is a leap year");

    }
    else if (year == 200)
    {
        Console.WriteLine("this year is a leap year");
    }
    else
    {
        Console.WriteLine("this year is not a leap year");
    }

}

void fifthTask()
{
    Console.WriteLine("Enter number");
    int num = Convert.ToInt32(Console.Read());

    if (num % 2 == 0)
    {
        Console.WriteLine("your number is even");
    }
    else
    {
        Console.WriteLine("your number is odd");
    }
}