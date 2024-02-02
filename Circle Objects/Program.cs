using Circle_Objects;

Validator validator = new Validator();

Console.WriteLine("Welcome to the circle creater");
Console.Write("Please enter the radius of the circle you'd like to create!: ");


double userRadius = validator.validDouble();



Circle userCircle = new Circle(userRadius);
bool circleCycle = true;

while (circleCycle)
{
    displayCircle(userCircle);

    circleCycle = validator.validYN();



    if (circleCycle)
    {
        Console.WriteLine("\nThe circle is growing!");
        userCircle.Grow();
    }
    else
    {
        Console.WriteLine($"\nYou circles final radius was {userCircle.GetRadius()}! Goodbye!");
    }
}


static void displayCircle(Circle circle)
{
    Console.WriteLine($"\nYour circles diameter is: {circle.CalculateDiameter()}");
    Console.WriteLine($"Your circles circumference is: {circle.CalculateCircumference()}");
    Console.WriteLine($"Your circles area is: {circle.CalculateArea()}");
}
