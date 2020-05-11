using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnToMainScene : MonoBehaviour
{

    public void ReturnToMainMenu()
    {
        Debug.Log("Loading main menu");
        SceneManager.LoadScene("Menu");
    }

}
