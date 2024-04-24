using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal
{
    //Every class still me can access this
    protected private string name;

    private int health;

   public virtual void Move()
    {
        Debug.Log("Moving");
    }

    public abstract void Eat();  //This method is avstract, like a property.  
    //Now every class inheriting this, implement the abstract method.  Every Animal has
    //to eat

    public virtual void Sleep()
    {

    }

    public Animal(string animalName)
    {
        name = animalName;
    }
}
