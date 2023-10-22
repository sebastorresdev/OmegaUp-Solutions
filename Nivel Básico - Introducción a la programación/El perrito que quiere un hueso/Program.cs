var r1 = Console.ReadLine().Split(' ');
var r2 = Console.ReadLine().Split(' ');
int l1 = int.Parse(r1[0]), t1 = int.Parse(r1[1]);
int l2 = int.Parse(r2[0]), t2 = int.Parse(r2[1]);

if (l1 > l2 && t1 > t2)
{
    Console.WriteLine("Hueso 1");
}
else if (l2 > l1 && t2 > t1)
{
    Console.WriteLine("Hueso 2");
}
else
{
    Console.WriteLine("Perrito confundido :(");
}
