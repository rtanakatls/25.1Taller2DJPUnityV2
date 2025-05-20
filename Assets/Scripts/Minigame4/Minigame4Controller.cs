using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Minigame4Controller : MonoBehaviour
{
    [SerializeField] private List<Image> buttonImages;

    [SerializeField] private Sprite goodSprite;
    [SerializeField] private Sprite badSprite;



    private void Awake()
    {
        int badIndex=Random.Range(0, buttonImages.Count);
        int index = 0;
        foreach (Image image in buttonImages)
        {
            image.gameObject.GetComponent<Button>().onClick.AddListener(()=>
            { 
                OnClicked(image.gameObject); 
            });
            if (index == badIndex)
            {
                image.sprite = badSprite;

            }
            else
            {
                image.sprite = goodSprite;
            }
            index++;
        }
    }

    private void OnClicked(GameObject obj)
    {
        Destroy(obj.GetComponent<Image>());
        Invoke("GameOver",1f);
    }

    private void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
