using UnityEngine;
using UnityEngine.SceneManagement;

public class restart_button : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
