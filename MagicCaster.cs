public class MagicCaster : Enemy
{
    public MagicCaster(string name, int health, List<Attack> MagicList) :base(name, health)
    {

    }
     public MagicCaster(string name, int health = 80) :base(name, health)
    {
        
    }

    public void Heal(Enemy Target)
    {
        Target.Health += 40;
        Console.WriteLine($"{Name} has healed {Target.Name} by 40 points and bringing them to {Target.Health} HP.");
    }
}