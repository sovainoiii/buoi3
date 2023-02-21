// Bai lam cua Pham Duc Minh
using exercise2;
Console.WriteLine("----------DOG-----------");
Dog dog = new Dog(TypeAnimal.Mammal, "Lu", Breed.Spaniel);
dog.Info();
Console.Write("Dog sound: ");
dog.Sound();
Console.WriteLine("----------CAT-----------");
Cat cat = new Cat(TypeAnimal.Mammal, "Miu");
cat.Info();
Console.Write("Cat sound: ");
cat.Sound();
cat.Climb(Climb.Wall);
Console.WriteLine("----------DUCK-----------");
Duck duck = new Duck(TypeAnimal.Bird, "Quéc");
duck.Info();
Console.Write("Dog sound: ");
duck.Sound();
duck.Swim(Swim.Pool);