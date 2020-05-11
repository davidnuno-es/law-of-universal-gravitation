using UnityEngine;
using UnityEngine.UI;

public class MassObjectsSlider : MonoBehaviour
{
    public Text txt;
    Slider slider;

    float value = 0;

    private void Start()
    {
        slider = GetComponent<Slider>();
        value = slider.value;
        txt.text = value + " Kg";
        SceneInfo.commonMass = (int)value;
    }

    // Update is called once per frame
    void Update()
    {
        if (value != slider.value)
        {
            value = slider.value;
            txt.text = value + " Kg";
            SceneInfo.commonMass = (int)value;
        }
    }
}
