// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Room Calculator***");
double length = 0;
repeatL:
Console.Write("Enter length\t");
bool lengthValid = double.TryParse(Console.ReadLine(), out length);
if (lengthValid == false || length <= 0 )
{
    Console.WriteLine("Invalid integer");
    goto repeatL;
}

double width = 0;
bool widthValid = false;
while (widthValid == false)
{
    Console.Write("\nEnter Width\t");
    widthValid = double.TryParse(Console.ReadLine(), out width);
    if (widthValid == false || width <=0 )
    {
        Console.WriteLine("Invalid integer");
        widthValid = false;
    }
    
}
double areaValue = length * width;
double perimeterValue = 2 * length + 2 * width;
Console.WriteLine($"Area = {areaValue}\nPerimeter = {perimeterValue}");

if (areaValue >0 && areaValue <=250)
{
    Console.WriteLine("This is a small sized room");
}
else if (areaValue > 250 && areaValue < 650)
{
    Console.WriteLine("This is a medium sized room");
}
else if (areaValue >= 650)
{
    Console.WriteLine("This is a large sized room");
}