using System;

namespace Ex10_OrangeTree
{
    internal class OrangeTree
    {
        private int age;
        private int height;
        private int numOranges = 0;

        public OrangeTree(int age, int height)
        {
            this.age = age;
            this.height = height;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = 0;
            }
        }
        public int Height { get; internal set; }
        public bool TreeAlive { get; internal set; }
        public int NumOranges { get; internal set; }
        public int OrangesEaten { get; internal set; }

        internal void OneYearPasses()
        {
            age++;
            Height = height + 2;

            if (age >= 2)
            {
                NumOranges = (age - 1) * 5;
            }
        }

        internal void EatOrange(int v)
        {
            OrangesEaten = OrangesEaten + v;
            if (v > NumOranges)
            {
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            }

        }
    }
}