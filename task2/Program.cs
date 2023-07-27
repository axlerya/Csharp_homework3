

void distance(float x1, float y1,float z1,
            float x2, float y2, float z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    Console.WriteLine($"Расстояние между точками = {d}");
}

Console.WriteLine("Введите кординаты точки A(x,y,z)");
int[] cordOneDot = Array.ConvertAll<string,int>(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32 (elem);});
if (cordOneDot.Length  < 4 & cordOneDot.Length  > 2)
{
    Console.WriteLine("Введите кординаты точки B(x,y,z)");
    int[] cordTwoDot = Array.ConvertAll<string,int>(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32 (elem);});
    if (cordTwoDot.Length  < 4 & cordTwoDot.Length  > 2)
    {
        distance(cordOneDot[0], cordOneDot[1], cordOneDot[2],
        cordTwoDot[0], cordTwoDot[1], cordTwoDot[2]);
    }
    else Console.WriteLine("Введите кординаты точки B правильно");
}
else Console.WriteLine("Введите кординаты точки A правильно");
