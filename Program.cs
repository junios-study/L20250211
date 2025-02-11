using System.Data;

namespace L20250211
{
    public class Program
    {

        static void Main(string[] args)
        {
            Monster[] monsters = new Monster[2];
            monsters[0] = new Goblin();
            monsters[1] = new Boar();

            //다형성, virtual , override
            monsters[0].Move();
            monsters[1].Move();
        }
    }
}
