// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

//1*********************************************************

Console.WriteLine("Write a number");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)

{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd");
}


//2**************************************************************

{

    Console.WriteLine("How old are you?");
    string input = Console.ReadLine();
    int age = int.Parse(input);

    if (age < 13)
    {
        Console.WriteLine("You're a child.");

    }
    else if (age >= 20)

    {
        Console.WriteLine("You're an adult");

    }
    else
    {
        Console.WriteLine("You're a teenager");

    }
}

//3**************************************************************

{

    Console.WriteLine("Enter your score:");
    int score = int.Parse(Console.ReadLine());

    char grade;

    if (score >= 90 && score <= 100)
    {
        grade = 'A';
    }
    else if (score >= 80 && score <= 89)
    {
        grade = 'B';
    }
    else if (score >= 70 && score <= 79)
    {
        grade = 'C';
    }
    else if (score >= 60 && score <= 69)
    {
        grade = 'D';
    }
    else
    {
        grade = 'F';
    }

    Console.WriteLine("Your grade is: " + grade);
}


//4*************************************************************

{
    // Ask the user to input a year
    Console.WriteLine("Enter a year:");
    int year = int.Parse(Console.ReadLine());

    // Check if the year is a leap year
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    {
        Console.WriteLine(year + "is a leap year.");
    }
    else
    {
        Console.WriteLine(year + " is not a leap year.");
    }
}

//5********************************************************************

Console.WriteLine("Ange det första numret:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ange det andra numret:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ange det tredje numret:");
int num3 = int.Parse(Console.ReadLine());

int max;

if (num1 >= num2 && num1 >= num3)
{
    max = num1;
}
else if (num2 >= num1 && num2 >= num3)
{
    max = num2;
}
else
{
    max = num3;
}

Console.WriteLine("Det största talet är: " + max);

//6********************************************************************


Console.WriteLine("Ange ett tal:");
int num = int.Parse(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("Talet är positivt.");
}
else if (num < 0)
{
    Console.WriteLine("Talet är negativt.");
}
else
{
    Console.WriteLine("Talet är noll.");
}

//7******************************************************************



Console.WriteLine("Ange det totala beloppet för köpet:");
double amount = double.Parse(Console.ReadLine());

if (amount > 1000)
{
    amount = amount * 0.9;

    Console.WriteLine("Det slutgiltiga beloppet är: " + amount + " kr");

    //8***************************************************************

    Console.WriteLine("Ange ett nummer mellan 1 och 7:");
    int day = int.Parse(Console.ReadLine());


    switch (day)
    {
        case 1:
            Console.WriteLine("Måndag");
            break;
        case 2:
            Console.WriteLine("Tisdag");
            break;
        case 3:
            Console.WriteLine("Onsdag");
            break;
        case 4:
            Console.WriteLine("Torsdag");
            break;
        case 5:
            Console.WriteLine("Fredag");
            break;
        case 6:
            Console.WriteLine("Lördag");
            break;
        case 7:
            Console.WriteLine("Söndag");
            break;
        default:
            Console.WriteLine("Fel: Ange ett nummer mellan 1 och 7.");
            break;
    }



    //9**************************************************************


    string rightPassword = "CSharp123";

    Console.WriteLine("Ange lösenord:");
    string inputPassword = Console.ReadLine();

    if (inputPassword == rightPassword)
    {
        Console.WriteLine("Access granted");
    }
    else
    {
        Console.WriteLine("Access denied");
    }

    //10************************************************************


    Console.WriteLine("Vill du konvertera från Fahrenheit till Celsius (ange 'F') eller Celsius till Fahrenheit (ange 'C')?");
    string choice = Console.ReadLine();


    Console.WriteLine("Ange temperaturen du vill konvertera:");
    double temperature = double.Parse(Console.ReadLine());


    if (choice == "F")
    {

        double celsius = (temperature - 32) * 5 / 9;
        Console.WriteLine("Temperaturen i Celsius är: " + celsius);
    }
    else if (choice == "C")
    {

        double fahrenheit = (temperature * 9 / 5) + 32;
        Console.WriteLine("Temperaturen i Fahrenheit är: " + fahrenheit);
    }
    else if (choice == "f")
    {

        double celsius = (temperature - 32) * 5 / 9;
        Console.WriteLine("Temperaturen i Celsius är: " + celsius);
    }
    else if (choice == "c")
    {

        double fahrenheit = (temperature * 9 / 5) + 32;
        Console.WriteLine("Temperaturen i Fahrenheit är: " + fahrenheit);
    }
    else
    {
        Console.WriteLine("Fel: Ange 'F' för Fahrenheit till Celsius eller 'C' för Celsius till Fahrenheit.");

    }
}