
public class Attack 
{   
    // fields
    public string Name {get; set;}
    public int DamageAmount {get; set;}

    

    // constructor
    public Attack(string name, int damageAmount)
    {
        Name = name;
        DamageAmount = damageAmount;
    }
    
}