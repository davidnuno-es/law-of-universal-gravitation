using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnToMainScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ReturnToMainMenu);
    }

    private void ReturnToMainMenu()
    {
        Debug.Log("Loading main menu");
        SceneManager.LoadScene("Menu");
    }

}
