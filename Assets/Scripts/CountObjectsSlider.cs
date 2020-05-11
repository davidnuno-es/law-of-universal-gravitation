using UnityEngine;
using UnityEngine.UI;

public class CountObjectsSlider : MonoBehaviour
{

    public Text txt;
    Slider slider;

    float value = 0;

    private void Start()
    {
        slider = GetComponent<Slider>();
        value = slider.value;
        txt.text = value + "";
        SceneInfo.objectsCount = (int)value;
    }

    // Update is called once per frame
    void Update()
    {
        if(value != slider.value)
        {
            value = slider.value;
            txt.text = value + "";
            SceneInfo.objectsCount = (int)value;
        }
    }
}
