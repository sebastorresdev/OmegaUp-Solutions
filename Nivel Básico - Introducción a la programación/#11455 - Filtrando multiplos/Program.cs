int n, k;
n = Convert.ToInt32(Console.ReadLine());
int[] s = new int[n];

s = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

k = Convert.ToInt32(Console.ReadLine());

foreach (int i in s)
{
    Console.Write(i % k == 0 ? $"{i} " : "X ");
}