using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public float speed = 20f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Ici, tu peux gérer ce qui arrive lorsque le projectile touche un autre objet
        Destroy(gameObject); // Détruit le projectile
    }
}