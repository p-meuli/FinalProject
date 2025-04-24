using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }
    void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0) 
        {
            // We dead
            //restart at beginning
        }
    }

 void Healing(int amount)
    {
        currentHealth += amount;
        if(currentHealth > maxHealth) 
        {
            currentHealth = maxHealth;
            // Crouch
            // press and Hold K for 1 hp per sec
        }
    }

}
// health 
// hp = 100
// when Damage is taken 
// hp = current hp - (1 * enemy attack strenght)

// public int enemyAttackStrenght
// public int health
// public string "Hp"

// if current hp is greater than 0: keep going
// If current hp is less than or equals 0: die and restart.

// Can heal the player by pressing and holding the "K" button --> 1 hp per second.

// add sign that explains "Connect to the mycelium network to begin healing by pressing and holding 'K' to crouch" 