
public class Enemy
{
    // FIELDS
    // Name (i.e. Bandit, Boss, Guard)
    public string Name { get; set; }

    // Health
    public int Health { get; set; }

    // AttackList -- This will be a List of type Attack that will hold the various Attacks an enemy can perform
    public List<Attack> AttackList { get; set; }

    // Creating a constructor 
    public Enemy(string name, int health = 100)
    {
        Name = name;
        AttackList = new List<Attack>();
        Health = health;
    }
     public Enemy(string name, List<Attack> attackList, int health = 100)
    {
        Name = name;
        AttackList = attackList;
        Health = health;
    }

    // Methods
    // RandomAttack: the enemy object performs a randomized attack from their AttackList
    public void RandomAttack()
    {
        Random randomNum = new Random();
        // choosing arbitrary index from the AttackList
        int randomAttackIndex = randomNum.Next(0, AttackList.Count);
        Attack randomAttack = AttackList[randomAttackIndex];

        Console.WriteLine($"{Name} has decided to Attack with {randomAttack.Name} and has dealt a total damage of {randomAttack.DamageAmount} leaving the opponent with {Health = Health - randomAttack.DamageAmount}% HP.");
    }
    // Inside of the Enemy class
    public void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health -= ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name} via {ChosenAttack.Name} dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }

    // checking the current data values for the list of attacks
        // public void AttackInfo()
        // {
        //     foreach (Attack attack in AttackList)
        //     {
        //         Console.WriteLine(attack.Name);
        //     }
        // }

}