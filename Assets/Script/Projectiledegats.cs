using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            // Suppose que l'ennemi a un script de santé attaché
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
            Destroy(gameObject); // Détruire le projectile après avoir touché
        }
    }
}