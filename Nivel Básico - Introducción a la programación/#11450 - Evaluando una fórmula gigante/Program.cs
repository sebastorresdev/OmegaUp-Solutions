using System.Globalization;

var r = Console.ReadLine().Split(' ');

double x = double.Parse(r[0], CultureInfo.InvariantCulture);
double y = double.Parse(r[1], CultureInfo.InvariantCulture);
double z = double.Parse(r[2], CultureInfo.InvariantCulture);

double resut = (2 * x + y) * (y * y * y - z) / z / (((x + 2 * y + 3 * z) / (z - 2 * y - 3 * x)) + x * x + z * z);

Console.WriteLine(resut);