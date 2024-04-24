using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private Transform aim;
    //[SerializeField] private Bullet bulletPrefab;
    [SerializeField] private Weapon playerWeapon;
    
    protected override void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        healthPoints = new Health(5);
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
        //playerWeapon = new Weapon(bulletPrefab);
    }
    public override void SetWeapon(Weapon newWeapon)
    {
        base.SetWeapon(newWeapon);
        playerWeapon = newWeapon;

        
    }
    public void ChangedHealth(int health)
    {
        Debug.Log("Health has changed" + health);
        if (health <= 0)
        {
            Die();
        }
    }
    public override void Attack()
    {
        playerWeapon.ShootMe(aim.position, aim.rotation);
    }

    public override void Die()
    {
        GameManager.singleton.EndGame();
        Destroy(gameObject);
    }

    public override void Move(Vector2 direction, float angle)
    {
        base.Move(direction, angle);
    }
}
