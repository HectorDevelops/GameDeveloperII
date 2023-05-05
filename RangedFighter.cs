public class RangedFighter : Enemy
{
    public int Distance {get; set;}

    public RangedFighter(string name, List<Attack> AttackList, int distance = 5) : base(name)
    {
        Distance = distance;
    }
      public RangedFighter(string name, int distance = 5) : base(name)
    {
        Distance = distance;
    }

    public void Dash()
    {
        Distance = 20;
        Console.WriteLine($"{this.Name} has distanced themselves by {Distance} distance field.");
    }
}