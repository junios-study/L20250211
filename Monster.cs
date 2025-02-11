﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20250211
{
    public class Monster
    {
        public Monster()
        {
            Console.WriteLine("몬스터 생성자");
        }

        ~Monster() 
        {
            Console.WriteLine("몬스터 소멸자");
        }

        public int hp;
        public int gold;

        public void Attack()
        {
            Console.WriteLine("공격한다.");
        }

        public void Die()
        {

        }

        //virtual function table
        public void Move()
        {
            Console.WriteLine("몬스터 걷는다.");
        }
    }
}
