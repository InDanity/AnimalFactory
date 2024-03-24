﻿using System;
using System.Net;

public interface IAnimal
{
    public void speak();
}

public class Dog : IAnimal
{
    public void speak()
    {
        Console.WriteLine("Woof!");
    }
}


public class Cat : IAnimal
{
    public void speak()
    {
        Console.WriteLine("Meow!");
    }
}

public enum Animal
{
    Cat,
    Dog
}

public static class AnimalFactory
{
    
    public static IAnimal makeAnimal(Animal animal)
    {
        if (animal == Animal.Cat)
        {
            return new Cat();
        }

        else if (animal == Animal.Dog)
        {
            return new Dog();
        }

        else
        {
            throw new Exception ("Not a preset animal.");
        }
    }   
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        IAnimal doggie = AnimalFactory.makeAnimal(Animal.Dog);
        IAnimal kitty = AnimalFactory.makeAnimal(Animal.Cat);

        doggie.speak();
        kitty.speak();
        
    }
}