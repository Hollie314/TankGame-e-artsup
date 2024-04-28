using UnityEngine;

public class PlayerMovemente : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;

    private Rigidbody rb;
    private float forwardInput;
    private float rotationInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Lecture des entrées de l'axe vertical pour déplacement avant/arrière
        forwardInput = Input.GetAxis("Vertical");
        
        // Lecture des entrées du joystick droit pour la rotation
        rotationInput = Input.GetAxis("Horizontal");

        // Rotation basée sur le joystick droit
        transform.Rotate(Vector3.up, rotationInput * rotationSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // Déplacement en avant ou en arrière basé sur l'input
          Vector3 move = transform.forward * forwardInput * moveSpeed;
        //rb.MovePosition(rb.position + move * Time.fixedDeltaTime);
    }
}