using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    public override void Move()
    {
        base.Move();  //This means the parent is called and performs
        Debug.Log("Flying");  //This calls the parent and new stuff - Moving and Flying
    }
    public Bird(string newName) : base(newName)
    {
        name = newName;
    }

    public override void Eat()
    {
        
    }
}

//public class Penguin : Bird
//{

//}

//public class Eagle : Bird
//{

//}

//public class Chicken : Bird
//{

//}
