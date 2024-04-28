using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    private InputAction _shootAction;

    [SerializeField] public GameObject bullet;
    [SerializeField] public Transform fireSource;
    
    
    
    public void HandleShoot(InputAction.CallbackContext inputContext)
    {
        Instantiate(bullet, fireSource.position, fireSource.rotation);

    } 
}