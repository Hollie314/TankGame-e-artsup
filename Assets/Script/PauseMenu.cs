using UnityEngine;

namespace Script
{
    public class PauseMenu : MonoBehaviour
    {
        public GameObject pauseMenuUI;

        private bool isPaused = false;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (isPaused)
                {
                    ResumeGame();
                    QuitGame();
                }
                else
                {
                    Pause();
                }
            }
        }
        
        void Start()
        {
            pauseMenuUI.SetActive(false); // Assurez-vous que le menu de pause est désactivé au démarrage
            isPaused = false;
        }


        public void ResumeGame()
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f; // Reprend le temps normal
            isPaused = false;
        }

        public void Pause()
        {
            Time.timeScale = 0f; // Arrête le temps dans le jeu
            pauseMenuUI.SetActive(true);
            isPaused = true;
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
    public class MenuManager : MonoBehaviour
    {
        public GameObject menu;
        public MouseLook mouseLook;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P)) // Ou votre bouton pour le menu
            {
                menu.SetActive(!menu.activeSelf); // Active ou désactive le menu
                mouseLook.ToggleMouseLookActive(); // Active ou désactive MouseLook
            }
        }
    }

}
