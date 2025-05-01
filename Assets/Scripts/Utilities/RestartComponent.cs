using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartComponent : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
