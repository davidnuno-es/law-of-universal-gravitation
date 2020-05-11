using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{

    public Button button;
    // Start is called before the first frame update
    void Start()
    {

    #if UNITY_STANDALONE
            Debug.Log("Standalone platform detected");
            button.onClick.AddListener(Exit);
    #elif UNITY_WEBGL
            Debug.Log("WebGL platform detected");
            button.gameObject.SetActive(false);
    #else
            Debug.Log("WebGL or other platform detected");
    #endif

    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
}
