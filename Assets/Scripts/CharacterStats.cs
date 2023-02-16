using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public int damage;
    public int armor;

    public event System.Action<int, int> OnHealthChange;

    private void Awake()
    {
        currentHealth = maxHealth;

    }

    public virtual void TakeDamage(int damage)
    {
        damage -= armor;
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        if (OnHealthChange != null)
        {
            OnHealthChange(maxHealth, currentHealth);
        }

        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Debug.Log(transform.name + " died!");
    }
}
