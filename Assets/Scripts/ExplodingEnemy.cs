using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingEnemy : Enemy
{
    public int explosionDamage;
    Player player;
    private Weapon exEnemyWeapon;
    public Health enemyHealth;

    public override void Attack()
    {
        Debug.Log("This enemy exploedes");
        Die();
    }

    public ExplodingEnemy(string enemyName) : base(enemyName)
    {

    }
}
