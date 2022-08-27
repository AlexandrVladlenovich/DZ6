// y = k1 * x + b1;
// y = k2 * x + b2;
// x = (b1 - b2) / (k2 - k1);
// y = (k1 * (b1 - b2) / (k2 - k1)) + b1;
Console.Clear();
Console.WriteLine(X(5, 9, 2, 4));
string X(double k1, double k2, double b1, double b2)
{
    string result = string.Empty;
    double x = 0;
    double y = 0;
    x = (b1 - b2) / (k2 - k1);
    y = (k1 * (b1 - b2) / (k2 - k1)) + b1;
    result = $"Координаты точки пересечения прямых: ({x}, {y})";
    return result;
}