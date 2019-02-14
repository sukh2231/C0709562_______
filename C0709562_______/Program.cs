class Program
{
    static void Main(string[] args)
    {
        //new Building().Run();
        //string lookFor = "Tools";
        //Console.WriteLine("{0} found in area {1} ", lookFor, Search.FindItem(lookFor));

        Greenhouse a = new Greenhouse();
        a.Run();
        Console.WriteLine("total cost is {0} ", a.calculateTotalCost());

    }
}
class Greenhouse
{
    Flower rose, sunflower, lily, jasmin, head, tail;
    public void Run()
    {
        rose = new Flower("Rose", "Red", 10);
        sunflower = new Flower("Sunflower", "Yellow", 2);
        lily = new Flower("Lily", "White", 5);
        jasmin = new Flower("Jasmin", "Orange", 7);

        rose.previousFlower = null;
        rose.nextFlower = sunflower;
        sunflower.previousFlower = rose;
        sunflower.nextFlower = lily;
        lily.previousFlower = sunflower;
        lily.nextFlower = jasmin;
        jasmin.previousFlower = lily;
        jasmin.nextFlower = null;
        head = rose;
    }

    public int calculateTotalCost()
    {
        Flower temp;
        int totalcost = 0;
        temp = head;
        while (temp.nextFlower != null)
        {
            temp.nextFlower.cost += totalcost;
            temp = temp.nextFlower;
        }

        return totalcost;
    }
}

class Flower
{
    public Flower(string _name, string _color, int _cost)
    {
        name = _name;
        color = _color;
        cost = _cost;
    }
    public Flower nextFlower;
    public Flower previousFlower;
    public int cost;
    public string name;
    public string color;
}