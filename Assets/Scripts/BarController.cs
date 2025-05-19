using UnityEngine;
using UnityEngine.UI;

public class BarController : MonoBehaviour
{
    private Image image;
    private float maxValue;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void Init(float value, float maxValue)
    {
        this.maxValue = maxValue;
        image.fillAmount = value / maxValue;
    }

    public void SetValue(float value)
    {
        image.fillAmount = value / maxValue;
    }
}
