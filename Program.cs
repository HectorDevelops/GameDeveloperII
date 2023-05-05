

// Enemy Instantiation
Enemy malfoy = new Enemy("Malfoy", 100);

// Instantiating attack styles
Attack melee = new Attack("Melee", 10);
Attack magic = new Attack("Magic", 15);
Attack ranged = new Attack("Ranged", 17);

// Adding attack styles to list 
malfoy.AttackList.Add(melee);
malfoy.AttackList.Add(magic);
malfoy.AttackList.Add(ranged);

// Displaying a random attack without dealing damage
malfoy.RandomAttack();


// Instantiating a Melee Fighter
MeleeFighter sloane = new MeleeFighter("Sloane", 120);

// Melee attacks instantiating 
Attack punch = new Attack("Punch", 20);
Attack kick = new Attack("Kick", 15);
Attack tackle = new Attack("Tackle", 25);

// Adding each attack style to the list 
sloane.AttackList.Add(punch);
sloane.AttackList.Add(kick);
sloane.AttackList.Add(tackle);

// Creating foreach loop to display attack style and damage affiliated with style 
foreach (Attack attackName in sloane.AttackList)
{
    Console.WriteLine($"{attackName.Name} deals a total of {attackName.DamageAmount} damage");
}
Console.WriteLine("\n");

// Performing a Rage attack
// sloane.Rage();


// RangedFighter List of Attacks 
Attack arrowShooting = new Attack("Arrow", 20);
Attack knifeThrow = new Attack("Knife", 15);

RangedFighter robinhood = new RangedFighter("Robinhood", 5);

robinhood.AttackList.Add(arrowShooting);
robinhood.AttackList.Add(knifeThrow);

foreach (Attack attackName in robinhood.AttackList)
{
    Console.WriteLine($"{attackName.Name} deals a total of {attackName.DamageAmount} damage");
}
Console.WriteLine("\n");



// Magic Caster List of Attacks
Attack fireBall = new Attack("Fire Ball", 25);
Attack lightningBolt = new Attack("Lightning Bolt", 20);
Attack staffStrike = new Attack("Staff Strike", 10);

MagicCaster darkMagician = new MagicCaster("Dark Magician", 80);

darkMagician.AttackList.Add(fireBall);
darkMagician.AttackList.Add(lightningBolt);
darkMagician.AttackList.Add(staffStrike);

foreach (Attack attackName in darkMagician.AttackList)
{
    Console.WriteLine($"{attackName.Name} deals a total of {attackName.DamageAmount} damage");
}
Console.WriteLine("\n");

// Perform the Kick Attack from your Melee class character on your Ranged character
Console.WriteLine("Performing the kick attack:");
sloane.PerformAttack(robinhood, kick);

// Perform the Rage method from your Melee class character on your Magic Caster character
Console.WriteLine("Performing rage:");
sloane.Rage(darkMagician);

// Perform the Shoot an Arrow Attack from your Ranged character on your Melee character (if you wrote everything as listed above, you should not have been able to attack due to the Distance constraint)

// Setting this condition to only attack IF robinhood has enough distance
if (robinhood.Distance > 5)
{
    Console.WriteLine(robinhood.Distance);
    robinhood.PerformAttack(sloane, arrowShooting);
}
Console.WriteLine("Ranged character performing a Dash:");
robinhood.Dash();

robinhood.PerformAttack(sloane, arrowShooting);

// Perform a Fireball Attack from your Magic Caster on your Melee character
darkMagician.PerformAttack(sloane, fireBall);

// Have the Magic Caster perform the Heal method on the Ranged character
darkMagician.Heal(robinhood);
// Have the Magic Caster perform the Heal method on themselves
darkMagician.Heal(darkMagician);