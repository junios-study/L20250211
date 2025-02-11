using System.Data;

namespace L20250211
{
    public class 태규부모님
    {
        private int money;
    }

    public class 태규 
    {
       // private int money;
    }


    //Encapsulation
    public class 리모콘
    {
        public void 반도체만져보기()
        {
            반도체때리기();
        }

        protected void 반도체때리기()
        { 
        }

        protected int 반도체 = 1;
    }
    
    //              캡슐화         상속
    //public         O             O
    //protected      X             O
    //private        X             X
    public class 보연
    {
        static void Main(string[] args)
        {
            리모콘 티비리모콘 = new 리모콘();
            티비리모콘.반도체만져보기();

            태규 본체 = new 태규();
            태규.mon
        }
    }
}
