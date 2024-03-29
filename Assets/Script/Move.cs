using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de déplacement du joueur
    public float rotationSpeed = 100f; // Vitesse de rotation du joueur

    private Rigidbody rb; // Référence au composant Rigidbody pour le déplacement 3D
    private Vector3 movement; // Stocke les axes de déplacement en 3D

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtient le composant Rigidbody de l'objet
    }

    void Update()
    {
        // Input.GetAxis récupère un input de l'axe horizontal (gauche/droite) et vertical (avant/arrière)
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        
        // Applique la rotation basée sur le mouvement horizontal
        if (movement.x > 0)
        {
            // Tourne à droite
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        else if (movement.x < 0)
        {
            // Tourne à gauche
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        // Déplace le Rigidbody basé sur l'input de l'utilisateur
        rb.MovePosition(rb.position + transform.forward * movement.z * moveSpeed * Time.fixedDeltaTime);
    }
}