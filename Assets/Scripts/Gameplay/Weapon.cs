using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]

public class Weapon : ScriptableObject
{

    [SerializeField] private int damage;
    [SerializeField] Bullet bulletReference;
    [SerializeField] private string weaponName;
    //[SerializeField];

    public void ShootMe(Vector2 position, Quaternion direction)
    {
        Bullet tempBullet = GameObject.Instantiate(bulletReference, position, direction);
        tempBullet.SetUpBullet("Enemy", 1);
    }

    public Weapon()
    {

    }

    public Weapon(Bullet bulletPrefab)
    {
        bulletReference = bulletPrefab;
    }
   


}
