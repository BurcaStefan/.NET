using IntroducereIn.NET_lab2.Interfaces;

namespace IntroducereIn.NET_lab2.Business
{
    public class Bird : Animal, IMovable
    {
        public Bird(string name, int age) : base(name, age)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($" Chirp ");
        }

        public void Move()
        {
            Console.WriteLine($"Bird name {Name} says: Chirp and moves by flap flap");
        }
    }
}
