int n, s = 0;

n = int.Parse(Console.ReadLine());

var r1 = Console.ReadLine().Split(' ');
int[] a = new int[n], b = new int[n];

for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(r1[i]);
}

var r2 = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    b[i] = int.Parse(r2[i]);
}

for (int i = 0; i < n; i++)
{
    s += a[i] * b[i];
}

Console.WriteLine(s);