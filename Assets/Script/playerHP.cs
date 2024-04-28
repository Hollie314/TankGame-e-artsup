using System;
using Script;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    [Obsolete("Obsolete")]
    void Die()
    {
        // Ici, mettez le code pour gérer la mort du joueur, comme jouer une animation, afficher un écran de Game Over, etc.
        Debug.Log("Player is dead!");
        Destroy(gameObject); // Détruit l'objet joueur
        Debug.Log("Player is dead!");
        FindObjectOfType<GameManagere>().EndGame();

    }
}