// See https://aka.ms/new-console-template for more information

using IntroducereIn.NET_lab2.Business;
using IntroducereIn.NET_lab2.Interfaces;

try
{
    Animal dog = new Dog("Rex", 3);
    Animal cat = new Cat("Tom", 2);
    Animal bird = new Bird("Tweety", 5);

    List<Animal> animals = new() { dog, cat, bird };

    foreach (var animal in animals)
    {
        animal.MakeSound();
        if (animal is IMovable movable)
        {
            movable.Move();
        }
    }
}
catch (Exception ex)
{
    //cw
    Console.WriteLine($"An error occured: {ex.Message}");
	throw;
}