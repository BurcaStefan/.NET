using IntroducereIn.NET_lab2.Interfaces;

namespace IntroducereIn.NET_lab2.Business
{
    public class Cat:Animal,IMovable
    {
        public Cat(string name, int age) : base(name, age)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine($" Meow ");
        }

        public void Move()
        {
            Console.WriteLine($"Cat name {Name} says: Meow and moves by running");
        }
    }


}
