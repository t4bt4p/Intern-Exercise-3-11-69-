class Box
{
    private double width; //เก็บความกว้างของกล่อง
    private double height; //เก็บความสูงของกล่อง
    private double length; //เก็บความยาวของกล่อง


    public double faceArea()
    {
        return width * height;
    }
    public double topArea()
    {
        return width * length;
    }
    public double sideArea()
    {
        return height * length;
    }

    public double area()
    {
        return 2 * faceArea() + 2 * topArea() + 2 * sideArea();
    }

    public Box(double width, double height, double length)
    {
        this.width = width;
        this.height = height;
        this.length = length;
    }
    public Box(double side)
    {
        this.width = side;
        this.height = side;
        this.length = side;
    }
    public Box(Box oldbox)
    {
        this.width = oldbox.width;
        this.height = oldbox.height;
        this.length = oldbox.length;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Box box1 = new Box(2.0, 3.0, 4.0);
        Box box2 = new Box(5.0, 6.0, 7.0);
        Box box3 = new Box(4.0);
        Box box4 = new Box(box1);

        System.Console.WriteLine("Box 1 Area: " + box1.area());
        System.Console.WriteLine("Box 2 Area: " + box2.area());
        System.Console.WriteLine("Box 3 Area: " + box3.area());
        System.Console.WriteLine("Box 4 Area: " + box4.area());
    }
}