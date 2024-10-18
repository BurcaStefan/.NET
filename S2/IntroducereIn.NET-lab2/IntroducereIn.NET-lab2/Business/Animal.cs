namespace IntroducereIn.NET_lab2.Business
{
    public abstract class Animal
    {
        //prop creaza setere si getere
        public string Name { get; private set; }
        public int Age { get; private set; }

        //ctor creaza constructor
        //ctrl+. pe name o sa creeze un meniu de unde poti lua si Name=name;
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();
    }
}
