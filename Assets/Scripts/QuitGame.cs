using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Exit);
    }

    // Update is called once per frame
    private void Exit()
    {
        Application.Quit();
    }
}
