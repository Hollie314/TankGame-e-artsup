using UnityEngine;

public class bullet : MonoBehaviour
{
    public string cible_tag;
     void Update()
    {
        Destroy(this.gameObject, 5);
    }

    void Start()
    {
        //Destroy(this.gameObject, 5);
        Rigidbody rb = GetComponent<Rigidbody>();
        float speed = 20;
        rb.velocity = transform.forward * speed;

    }
    
    private void OnCollisionEnter(Collision other)
    {
        //en gros tu check le tag des object, donc faut que le nom entre parenthèse soit le mm que les objets que tu veux virer
        if (other.collider.CompareTag(cible_tag))
        {
            Destroy(other.gameObject);
        }
    }
}
