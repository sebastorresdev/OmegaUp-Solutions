var n = int.Parse(Console.ReadLine() ?? "0");
string[] input = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
int[] numberArray = new int[9];
int[] signeArray = new int[9];
int max = 0, index = 0, count=0;
for (int i = 0; i < n; i++)
{
    int number = int.Parse(input[i]);
    numberArray[Math.Abs(number) - 1]++;
    signeArray[Math.Abs(number) - 1] += number > 0 ? 1 : 0;
}

for (int i = 0; i < 9; i++)
{
    if (numberArray[i]>max) 
    {
        max = numberArray[i];
        index = i;
        count = signeArray[i];
    }
}

Console.WriteLine(index+1);
Console.WriteLine($"{count} {max-count}");