using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private float attackDistance;
    [SerializeField] private Bullet bullet;
    private Player player;
    private Weapon Weapon;
    private float time;
    
    protected override void Start()
    {
       
    }

    public void SetUpEnemy(int healthPar)
    {
        healthPoints = new Health(healthPar);
        player = FindAnyObjectByType<Player>();
        healthPoints.OnHealthChanged.AddListener(CheckHealth);
    }

    private void CheckHealth(int health)
    {
        if (health <= 0)
        {
            //increase score
            GameManager.singleton.scoreManager.IncreaseScore();
            Destroy(gameObject);  //Dies

        }
    }
    private void FixedUpdate()
    {
        if (player != null)
        {
            Vector2 direction = player.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y - transform.position.y, direction.x - transform.position.x) * Mathf.Rad2Deg;
            Move(direction, angle);
        }
    }
    public string enemyName;

    public Enemy(string enemyName)
    {
        

    }

    public override void Attack()
    {
        
    }

    public override void Die()
    {
        
    }

    public override void Move(Vector2 direction, float angle)
    {
        //if distance from target is lesser than attackDistance
        if(Vector2.Distance(player.transform.position, transform.position) > attackDistance)
        {
            base.Move(direction, angle);
        }
        else//everytime the enemy is close to the player
        {
            //stop immediately
            //rigidBody.velocity = Vector2.zero;

            player.ReceiveDamage();
        }
        
    }

    //need something that calls the method, counts time, and then calls again using Time.deltaTime


}
