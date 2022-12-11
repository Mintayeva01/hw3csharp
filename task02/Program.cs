double x1 = 0;
double x2 = 1;
double y1 = 2;
double y2 = 7;

GetDistance(x1,x2,y1,y2);
double result = GetDistance(x1,x2,y1,y2);
static double GetDistance(double x1,double x2,double y1,double y2)
{
    return Math.Sqrt (Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
}

Console.WriteLine (result);

