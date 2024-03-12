using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbtn : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
