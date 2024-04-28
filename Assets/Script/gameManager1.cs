using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject gameOverPanel; // Référence au panneau de fin de jeu

    private int totalTargets = 5;
    private int destroyedTargets = 0;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void RegisterTarget()
    {
        totalTargets++;
    }

    public void TargetDestroyed()
    {
        destroyedTargets++;
        Debug.Log($"Target destroyed. Count: {destroyedTargets}/{totalTargets}");
        CheckGameOver();
    }

    void CheckGameOver()
    {
        Debug.Log("Checking if game is over...");
        if (destroyedTargets >= totalTargets)
        {
            Debug.Log("Game over!");
            gameOverPanel.SetActive(true);
        }
    }

}