using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    private bool isMouseLookActive = true; // Démarrer par défaut à vrai

    void Start()
    {
        UpdateCursorLock();
    }

    void Update()
    {
        if (isMouseLookActive)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }

    public void ToggleMouseLookActive()
    {
        isMouseLookActive = !isMouseLookActive;
        UpdateCursorLock();
    }

    private void UpdateCursorLock()
    {
        if (isMouseLookActive)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}