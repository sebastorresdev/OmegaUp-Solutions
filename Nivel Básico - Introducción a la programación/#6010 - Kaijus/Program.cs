long jaegers = long.Parse(Console.ReadLine());
long kaijus = 1;
int year = 2018;

while (kaijus <= jaegers)
{
    kaijus *= 2;
    year++;
}
    
Console.WriteLine(year);