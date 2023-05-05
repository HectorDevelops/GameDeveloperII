public class MeleeFighter : Enemy
{
    public MeleeFighter(string name, int health, List<Attack> AttackList) : base(name, AttackList, health)
    {

    }
    public MeleeFighter(string name, int health) : base(name, health)
    {

    }
    public void Rage(Enemy Target)
    {
        Health -= 10;
        this.RandomAttack();
    }
}