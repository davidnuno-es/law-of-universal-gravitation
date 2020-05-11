using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(changeScene);
    }
    
    private void changeScene()
    {
        Debug.Log("Loading game scene");
        SceneManager.LoadScene("GameScene");
    }
}
