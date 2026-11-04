class Dice
{
    int dice = 0;
    Random random = new Random();
    public Dice()
    {
        dice = 0;
    }
    public int Throw()
    {
        return dice = random.Next(1, 7);

    }
}
class programs
{
    public static void Main(String[] args)
    {
        int mark1 = 0,mark2 = 0, i = 0;
        Dice dic1 = new Dice();
        Dice dic2 = new Dice();
        while(mark1 != 1 || mark2 !=1) {
            mark1 = dic1.Throw();
            mark2 = dic2.Throw();
            i = i + 1;
            Console.WriteLine("{0} Mark of Dice is : [{1}] [{2}]", i, mark1,mark2);
            System.Threading.Thread.Sleep(10);
        }
        Console.WriteLine("Throw of both dice = 1 is : " + i + " time");
        Console.ReadLine();
    }
}