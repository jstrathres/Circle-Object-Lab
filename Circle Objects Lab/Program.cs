using Circle_Objects_Lab;
Console.WriteLine("Welcome to the Circle Tester");

int circleCount = 0;
bool restart = true;

while (restart)
{
    Console.WriteLine("Enter radius:");
    double radius;
    while(!double.TryParse(Console.ReadLine(), out radius))
    {
        Console.WriteLine("Invalid input: Try again");
    }

    Circle circle = new Circle(radius); //dont quite understand this
    Console.WriteLine("Circumference" + circle.CalculateFormattedCircumference());
    Console.WriteLine("Area" +circle.CalculateFormattedArea());
    circleCount++;

    Console.WriteLine("Continue? y/n");
    string response = Console.ReadLine();

    if(response == "y")
    {
        restart = true;
    }
    else
    {
        Console.WriteLine("Goodbye. You created " + circleCount + " Circle Objects");
        restart= false;
    }    
}


