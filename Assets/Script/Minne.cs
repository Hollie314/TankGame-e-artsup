using UnityEngine;

public class Mine : MonoBehaviour
{
    public float explosionRadius = 5f;
    public float explosionForce = 1000f;
    public int damage = 50; // Dégâts infligés par la mine
    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player")) // Assurez-vous que votre joueur a un tag "Player"
        {
            Explode();
        }
    }

    void Explode()
    {
        // Afficher l'effet d'explosion
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }

        // Appliquer une force d'explosion et des dégâts
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (var hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            PlayerHealth health = hit.GetComponent<PlayerHealth>();

            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }

            if (health != null)
            {
                health.TakeDamage(damage);
            }
        }

        // Détruire la mine
        Destroy(gameObject);
    }
}