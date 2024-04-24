using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : PickUp
{

    [SerializeField] private Weapon newWeapon;

    protected override void PickMe(Character characterToChange)
    {
        //call method in character or player to change the weapon
        //Send new weapon to the player
        //Hint:  
        characterToChange.SetWeapon(newWeapon);
        base.PickMe(characterToChange);
    }

}
