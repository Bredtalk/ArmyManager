namespace ArmyManager;

public abstract class Character
{
    public int Id;
    public string Name;
    public int HP;
    public int AttackPower;

    public abstract void Showinfo();

    public abstract void Attack(Character target);
}