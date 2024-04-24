using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private string targetTag;
    public int damage;
    public float bulletSpeed;
    public float timeToDestroy;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }
    private void Update()
    {
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }
    public void Explode()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            //Do Damage to Enemy
            collision.GetComponent<iDamageable>().ReceiveDamage(2);
            Destroy(gameObject);
        }
    }
    
    public void SetUpBullet(string tag, int damageParam)
    {
        damage = damageParam;
        targetTag = tag;
    }

    public Bullet(int newDamage, int bulletSpeed)
    {

    }
}
