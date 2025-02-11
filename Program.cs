using System.Data;

namespace L20250211
{
    public class Program
    {
        public class GameObject
        {
            public virtual void Render()
            {

            }
        }

        public class Cube : GameObject
        {
        }

        public class Box : GameObject
        {
            public override void Render()
            {

            }
        }



        static void Main(string[] args)
        {
            Monster[] monsters = new Monster[2];
            monsters[0] = new Goblin();
            monsters[1] = new Boar();
        

            //다형성, virtual , override
            monsters[0].Move();
            monsters[1].Move();

            GameObject[] gameObjects = new GameObject[2];
            gameObjects[0] = new Cube();
            gameObjects[1] = new Box();

            //Render All
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[0].Render();
                gameObjects[1].Render();
            }

        }
    }
}
