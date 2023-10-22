class Program
{
    static void Main()
    {
        // Lee los tres números enteros
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        // Imprime los resultados en una sola línea
        Console.WriteLine($"{a < b} {c > a} {a == b} {a != c} {c <= b}");
    }
}
