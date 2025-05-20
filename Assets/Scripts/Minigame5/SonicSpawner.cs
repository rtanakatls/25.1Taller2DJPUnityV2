using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SonicSpawner : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject prefab;

    private int amount;

    private void Awake()
    {
        amount = Random.Range(5, 20);
        for(int i=1;i<=amount;i++)
        {
            GameObject go = Instantiate(prefab);
            go.GetComponent<SpriteRenderer>().color=new Color(Random.value, Random.value, Random.value);
            Vector2 position = transform.position;
            go.transform.position = position+ Random.insideUnitCircle * 4;
        }
        button.onClick.AddListener(OnValidateAmount);
    }

    private void OnValidateAmount()
    {
        int value=int.Parse(inputField.text);
        if(value==amount)
        {
            text.text = "Correcto";
        }
        else
        {
            text.text = "Incorrecto";
        }
        Invoke("GameOver", 1f);
    }

    private void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
