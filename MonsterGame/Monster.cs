using System;

namespace MonsterGame;

public class Monster
{
    public string Name {get;set;}
    public int Hp {get;set;}
    public string Type {get;set;}
    public int Defeated {get;set;}


    public Monster()
    {
        Defeated = 0;
    }

    public Monster(string name, int hp, string type, int defeated = 0)
    {
        Name = name;
        Hp = hp;
        Type = type;
        Defeated = defeated;
    }

}