using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SonicMinigame1 : MonoBehaviour
{
    private int food;
    private int lostFood;
    [SerializeField] private TextMeshProUGUI foodText;

    private Rigidbody2D rb2d;
    [SerializeField] private float speed;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        rb2d.linearVelocityX = h * speed;
    }

    public void LostFood()
    {
        lostFood++;
        if (lostFood >= 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            food++;
            Destroy(collision.gameObject);
            foodText.text = $"Food: {food}";
        }
    }
}
