namespace ArmyManager;

public class Archer : Character, IAttack
{
    public Archer(string charactername)
    {
        Name = charactername;
        HP = 75;
        AttackPower = 50;
    }
    public override void Showinfo()
    {
        Console.WriteLine($"{Name} HP: {HP}, Attack power: {AttackPower}");
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} is attacking {target.Name}!");
        target.HP -= AttackPower;
        if (target.HP <= 0)
        {
            Console.WriteLine($"{target.Name} is dead!");
        }
    }
}