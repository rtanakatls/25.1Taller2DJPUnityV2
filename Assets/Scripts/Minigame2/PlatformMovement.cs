using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private Button leftButton;
    [SerializeField] private Button rightButton;
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject lastObject;
    [SerializeField] private List<bool> hasPlatform;
    private int platformIndex;
    private int notSpawnedCount;

    private void Awake()
    {
        leftButton.onClick.AddListener(OnPressedLeft);
        rightButton.onClick.AddListener(OnPressedRight);
    }

    private void OnPressedLeft()
    {
        transform.position += Vector3.left;
        platformIndex++;
        TrySpawn();
        CheckGameOver();
    }

    private void OnPressedRight()
    {
        transform.position += Vector3.left * 2;
        platformIndex += 2;
        TrySpawn();
        TrySpawn();
        CheckGameOver();
    }

    private void TrySpawn()
    {
        float random = Random.value;
        if (random > 0.5f || notSpawnedCount >= 1)
        {
            hasPlatform.Add(true);
            Spawn();
        }
        else
        {
            hasPlatform.Add(false);
            notSpawnedCount++;
        }
    }
    
    private void Spawn()
    {
        GameObject obj=Instantiate(prefab,transform);
        obj.transform.position = lastObject.transform.position + (Vector3.right * (notSpawnedCount + 1));
        lastObject = obj;
        notSpawnedCount = 0;
    }

    private void CheckGameOver()
    {
        if (!hasPlatform[platformIndex])
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
