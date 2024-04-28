using UnityEngine;

public class Target : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.RegisterTarget(); // Enregistre chaque cible auprès du GameManager
    }

    void OnCollisionEnter(Collision other)
    {
        // Supposons que la collision avec un projectile entraîne la destruction de la cible
        if (other.gameObject.CompareTag("enemy"))
        {
            DestroyTarget();
        }
    }

    public void DestroyTarget()
    {
        // Logique pour détruire la cible, par exemple en réponse à un impact
        Destroy(gameObject);
        GameManager.Instance.TargetDestroyed(); // Notifie le GameManager que la cible a été détruite
    }
}