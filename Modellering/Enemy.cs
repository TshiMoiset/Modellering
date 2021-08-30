using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Diagnostics.Contracts;
using System;

namespace Modellering
{
    public class Enemy
    {
        public float x;
        public float y;

        public string name;
        public int health;
        public int damage;

        private float speed = 2.5f;

        public void move()
        {
            x += speed;
        }

        public void Hurt(int amount)
        {
            health -= amount;

            if (health < 0)
            {
                health = 0;

            }


        }
    }
}