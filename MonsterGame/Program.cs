namespace MonsterGame;

class Program
{
    static void Main(string[] args)
    {
        List<Monster> monsters = new List<Monster>
        {
            new Monster {Name = "Goblin", Hp = 30, Type = "Normal"},
            new Monster {Name = "Orc", Hp = 60, Type = "Elite"},
            new Monster {Name = "Dragon", Hp = 150, Type = "Boss"},
            new Monster {Name = "Slime", Hp = 20, Type = "Normal"},
        };

        string choice = "";

        while(choice != "0")
        {
            Menu.DisplayMenu();
            choice = Console.ReadLine();

            if(choice == "1")
            {
                foreach(Monster monster in monsters)
                {
                    Console.WriteLine($"Monster: {monster.Name}");
                }
            }
            else if(choice == "2")
            {
                Console.WriteLine("Enter Monster name:");
                string search = Console.ReadLine();

                Monster monster = monsters.Find(x => x.Name.ToLower() == search.ToLower());

                if(monster != null)
                {
                    Console.WriteLine($"Monster: {monster.Name} - HP: {monster.Hp} - Type: {monster.Type}");
                }
                else
                {
                    Console.WriteLine("Monster not found.");
                }
            }
            else if (choice == "3") 
            {
               List<Monster> strongMonsters = monsters.FindAll(x => x.Hp > 50);
               foreach(Monster monster in strongMonsters)
                {
                    Console.WriteLine($"{monster.Name} - Hp: {monster.Hp}");
                }
            }
            else if (choice == "4")
            {   
                monsters.Sort((a, b) => a.Hp.CompareTo(b.Hp));
                foreach(Monster monster in monsters)
                {
                    Console.WriteLine($"{monster.Name} - {monster.Hp}");
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine("Enter monster to defeat: ");
                string search = Console.ReadLine();
                
                Monster searchedMonster = monsters.Find(x => x.Name.ToLower() == search.ToLower());
                bool hasMonster = monsters.Any(x => x.Name.ToLower() == search.ToLower());

                if(hasMonster)
                {
                    Console.WriteLine($"{search} Defeated");
                    searchedMonster.Defeated++;
                } else
                {
                    Console.WriteLine($"{search} Not Found!");
                }
            }
            else if (choice == "6")
            {
                foreach(Monster monster in monsters)
                {
                    Console.WriteLine($"{monster.Name} : {monster.Defeated}");
                }
            }
        }
        
    }
}
