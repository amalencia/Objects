using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;


//Enemies and Players will derive from this class because all of
public abstract class Character : MonoBehaviour, iDamageable
{
    [SerializeField] private float speed;
    private int strength;
    protected Health healthPoints;

    [SerializeField] protected Rigidbody2D rigidBody;

    protected virtual void Start()
    {
        healthPoints = new Health(5);
    }

    public void ReceiveDamage()
    {
        healthPoints.DecreaseLife();
    }

    public abstract void Attack(); //a virtual method means that

    public abstract void Die();
    public virtual void SetWeapon(Weapon newWeapon)
    {

    }
    public virtual void Move(Vector2 direction, float angle)
    {
        //rigidBody.MovePosition(direction);  //another way
        //rigidBody.velocity = direction * speed * Time.deltaTime;  //This causes jittering because rate of frame updates and physics
        rigidBody.AddForce(direction.normalized * speed * Time.deltaTime * 1000f);  //easy to use
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public Character()
    {
        speed = 5f;
        
    }

    public Character(float speed, int health)
    {
        this.speed = speed;
        healthPoints = new Health(health);
    }

    public void ReceiveDamage(int damage)
    {
        healthPoints.DecreaseLife(damage);
    }

    public Health GetHealth()
    {
        return healthPoints;
    }
}
