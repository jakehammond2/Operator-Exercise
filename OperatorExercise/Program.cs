

using OperatorExercise;

Console.WriteLine(OperatorMain.Add(5, 2));
Console.WriteLine(OperatorMain.Subtract(2, 4));
Console.WriteLine(OperatorMain.Multiply(3, 6));
Console.WriteLine(OperatorMain.Divide(4, 2));
Console.WriteLine(OperatorMain.Modulus(5, 2));




Console.WriteLine("Enter in the first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter in the second number");
int b = Convert.ToInt32(Console.ReadLine());
int qoutient = a / b;
int remainder = a % b;


Console.WriteLine($"{a}/{b} is {qoutient} remainder {remainder}");





Console.WriteLine("What is the radius of your circle?");
var radius = double.Parse(Console.ReadLine());
Console.WriteLine($"The area of the circle with radius {radius} is {OperatorMain.AreaOfCirlce(radius)}"); 


