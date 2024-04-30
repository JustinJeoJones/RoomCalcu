Console.WriteLine("Welcome to the room calculator.");

//Input
Console.WriteLine("Please enter a length");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter a width");
double width  = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter a height");
double height = double.Parse(Console.ReadLine());

//calculating
double area = width * length;
double perimeter = 2 * (length + width);
double volume = length * width * height;
double surfaceArea = 2 * (length * width) + 2 * (length * height) + 2 * (height * width);

//results
Console.WriteLine("Area: " + area);
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine($"Volume: {volume}");
Console.WriteLine($"Surface Area: {surfaceArea}");

//room size 
if (area <= 250)
{
    Console.WriteLine("This room is small");
}
else if(area < 650)
{
    Console.WriteLine("This room is medium");
}
else
{
    Console.WriteLine("This room is large");
}