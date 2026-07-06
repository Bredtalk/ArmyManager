using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using ArmyManager;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Warrior> warriors = new List<Warrior>();
List<Archer> archers = new List<Archer>();
List<Character> masterArmy = new List<Character>();
masterArmy.AddRange(warriors);
masterArmy.AddRange(archers);



int numberofcharacters = 0;

Console.WriteLine($"There are currently  {numberofcharacters} characters");

Menu:
Console.WriteLine("ARMY MANAGER");
Console.WriteLine("==================");
Console.WriteLine(" 1. Thêm warrior" +
                  " 2. Thêm Archer" +
                  " 3. Hiển thị danh sách" +
                  " 4. Tấn công" +
                  " 5. Exit " );
string choice = Console.ReadLine();
switch (choice)
{
    case "1" : goto Addwarrior; break;
    case "2" : goto Addarcher; break;
    case "3" : goto Danhsach; break;
    case "4" : goto Tancong; break;
    case "5" : goto kethuc; break;
    default: Console.WriteLine("Invalid choice"); goto Menu;
}
Addwarrior:
Console.WriteLine("give this Character a name");
string name = Console.ReadLine();
Warrior warrior1 = new Warrior(name);
warriors.Add(warrior1);
Console.WriteLine($"{warrior1.Name} has joined your crew!");
numberofcharacters++;
goto Menu;

Addarcher:
Console.WriteLine("give this Character a name");
string archername = Console.ReadLine();
Archer archer1 = new Archer(archername);
archers.Add(archer1);
Console.WriteLine($"{archer1.Name} has joined your crew!");
numberofcharacters++;
goto Menu;

Danhsach:
Console.WriteLine("Warriors list:");
for (int i = 0; i < warriors.Count; i++)
{
    foreach (var boy in warriors)
    {
        Console.WriteLine($"{boy.Name}");
    }
}
Console.WriteLine("Archers list:");
for (int i = 0; i < archers.Count; i++)
{
    foreach (var boy in archers)
    {
        Console.WriteLine($"{boy.Name}");
    }
}
goto Menu;

Tancong:
masterArmy.Clear();
masterArmy.AddRange(warriors);
masterArmy.AddRange(archers);
Console.WriteLine("Who is attacking?");
string attacking = Console.ReadLine();
Character attacker = masterArmy.Find(c => c.Name == attacking);
Console.WriteLine("Who do you want to attack?");
string attacked = Console.ReadLine();
Character personattacked = masterArmy.Find(c => c.Name == attacked);
if (attacker != null && personattacked != null)
{
    attacker.Attack(personattacked);
}
else
{
    Console.WriteLine("Error: One or both of those characters do not exist in your army!");
}
goto Menu;
kethuc:
Console.WriteLine("See you next time!");






