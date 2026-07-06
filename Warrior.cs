using System.Runtime.CompilerServices;

namespace ArmyManager;

public class Warrior : Character, IAttack
{
    public Warrior(string charactername)
    {
        Name = charactername;
        HP = 120;
        AttackPower = 25;
    }
    public override void Showinfo()
    {
        Console.WriteLine($"{Name} HP: {HP}, Attack power = {AttackPower}");
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