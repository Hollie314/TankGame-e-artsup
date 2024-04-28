using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagere : MonoBehaviour
{
    public GameObject gameOverScreen;

    public void EndGame()
    {
        gameOverScreen.SetActive(true);
        // Arrêtez le temps de jeu
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        // Réinitialise le temps si vous l'aviez arrêté
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public class instance
    {
        public static void RegisterTarget()
        {
            throw new System.NotImplementedException();
        }

        public static void TargetDestroyed()
        {
            throw new System.NotImplementedException();
        }
    }
}