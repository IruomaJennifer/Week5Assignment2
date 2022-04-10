// See https://aka.ms/new-console-template for more information
using Exercise6;
Dog dog = new Dog("Woof", "Dog", 2, "Female");
Frog frog = new Frog("Ribbit", "Frog", 5, "Male");
Cat cat = new Cat("Meow", "Cat", 10, "Female");
Kitten kitten = new Kitten("Meow", "Kitten", 0.5, "Male");
Tomcat tomcat = new Tomcat("Yowl", "Tomcat", 5, "Male");
Animal[] animals = new Animal[] {dog,frog,cat,kitten,tomcat };
foreach (Animal animal in animals)
{
    Console.WriteLine($"Animal Name: {animal.Name}");
    Console.WriteLine($"Animal Age: {animal.Age} years old");
    animal.MakeSound();
    Console.WriteLine();
}
