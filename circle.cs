static void Circle(double diameter, double arcAngle)
{
    double radius = diameter / 2;
    double area = Math.PI * radius * radius;
    double circumference = Math.PI * radius * 2;
    double arcLength = circumference * (arcAngle / 360);
    
    Console.WriteLine($"Circle radius: {radius}\nArea: {area}\nCircumference: {circumference}\nArc length: {arcLength}");
}
Circle(5, 35);
