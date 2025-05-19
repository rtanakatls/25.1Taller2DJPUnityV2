using UnityEngine;
using UnityEngine.UI;

public class SonicManager : MonoBehaviour
{
    [SerializeField] private BarController foodBarController;
    [SerializeField] private BarController cleanBarController;
    [SerializeField] private BarController funBarController;
    [SerializeField] private BarController temperatureBarController;

    [SerializeField] private Button foodButton;
    [SerializeField] private Button cleanButton;
    [SerializeField] private Button funButton;
    [SerializeField] private Button temperatureButton;

    [SerializeField] private float currentFood;
    [SerializeField] private float maxFood;

    [SerializeField] private float currentClean;
    [SerializeField] private float maxClean;
    
    [SerializeField] private float currentFun;
    [SerializeField] private float maxFun;

    [SerializeField] private bool isHeaterOn;
    [SerializeField] private float currentTemperature;
    [SerializeField] private float minTemperature;  
    [SerializeField] private float maxTemperature;

    private void Awake()
    {
        foodButton.onClick.AddListener(OnFoodButtonClicked);
        cleanButton.onClick.AddListener(OnCleanButtonClicked);
        funButton.onClick.AddListener(OnFunButtonClicked);
        temperatureButton.onClick.AddListener(OnTemperatureButtonClicked);
    }

    private void OnFoodButtonClicked()
    {
        currentFood += 10;
        if (currentFood > maxFood)
        {
            currentFood = maxFood;
        }
        foodBarController.SetValue(currentFood);
    }


    private void OnCleanButtonClicked()
    {
        currentClean += 10;
        if (currentClean > maxClean)
        {
            currentClean = maxClean;
        }
        cleanBarController.SetValue(currentClean);
    }

    private void OnFunButtonClicked()
    {
        currentFun += 10;
        if (currentFun > maxFun)
        {
            currentFun = maxFun;
        }
        funBarController.SetValue(currentFun);
    }

    private void OnTemperatureButtonClicked()
    {
        if (isHeaterOn)
        {
            isHeaterOn = false;
        }
        else
        {
            isHeaterOn = true;
        }
    }

}
