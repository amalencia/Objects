using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal
{
    public override void Move()
    {
        base.Move();  //Calls the parent
        Debug.Log("Walking");  //This means both the parent and Child - Moving, then Walking
    }

    //public abstract void GiveBirth();
    public Mammal(string name) : base(name)
    {
        this.name = name;
    }

    public override void Eat()
    {

    }
}

//public class Platypus : Mammal
//{

//}

//public class Bat : Mammal
//{

//}