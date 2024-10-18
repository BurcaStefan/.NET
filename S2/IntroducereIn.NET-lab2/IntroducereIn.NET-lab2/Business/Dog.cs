using IntroducereIn.NET_lab2.Interfaces;

namespace IntroducereIn.NET_lab2.Business
{
    public class Dog : Animal, IMovable
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($" Bark ");
        }

        public void Move()
        {
            Console.WriteLine($"Dog name {Name} says: Bark and moves by running");
        }
    }
}
