double pitRadius = 5;
double pitHeight = 0.2;
double ballRadius = 0.05;

static double PitVolume(double radius, double height) // calculate the volume of the pit
{
    return Math.PI * Math.Pow(radius, 2) * height;
}

static double BallVolume(double radius) // calculate the volume of each ball
{
    return (Math.PI * Math.Pow(radius, 3) * 4)/3;
}

double ballNumber = Math.Floor(PitVolume(pitRadius, pitHeight)/BallVolume(ballRadius)); 
// calculate the amount of balls needed to fill the space

Console.WriteLine(ballNumber); // output the number
