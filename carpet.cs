static double cost(double width, double length, double ppm3)
{
    double carpetCost = width * length * ppm3;
    double underlayCost = width * length * 3;
    double grippersCost = width * 2 + length * 2;
    return carpetCost + underlayCost + grippersCost + 50;
}

Console.WriteLine(cost(7,6,17));
