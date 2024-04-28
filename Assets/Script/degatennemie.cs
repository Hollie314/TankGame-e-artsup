using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        // Ajouter des effets de mort, comme des animations ou des particules
        Debug.Log(gameObject.name + " est mort !");
        Destroy(gameObject); // Détruire l'ennemi
    }
}