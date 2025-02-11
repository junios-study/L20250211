using System.Data;

namespace L20250211
{
    public class Program
    {
        static void Main(string[] args)
        {
            Monster monster = new Goblin();
            int currentHP = monster.hp;
            monster.hp = 10;

            currentHP = monster.hp;
            Console.WriteLine(currentHP);
            // monster.GetHP();
            //monster.SetHP(100);

        }
    }
}
