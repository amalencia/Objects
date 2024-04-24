using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health 
{
    private int maxHealth = 100;
    private int currentHealth;
    public UnityEvent<int> OnHealthChanged = new UnityEvent<int>();
    public void DecreaseLife(int damage)
    {
        currentHealth -= damage;
        OnHealthChanged.Invoke(currentHealth);
    }

    public void DecreaseLife()
    {
        Debug.Log("Lost Health, current health: " + currentHealth);
        currentHealth -= 1;
        OnHealthChanged.Invoke(currentHealth);
    }

    public void DecreaseLife(int damage, float timer)
    {
        OnHealthChanged.Invoke(currentHealth);
    }

    public void IncreaseLife(int heal)
    {
        currentHealth += heal;
        OnHealthChanged.Invoke(currentHealth);
    }

    public Health(int maxHealth)
    {
        currentHealth = maxHealth;
        OnHealthChanged = new UnityEvent<int>();
    }
}
