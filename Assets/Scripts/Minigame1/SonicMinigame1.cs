using UnityEngine;

public class SonicMinigame1 : MonoBehaviour
{
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
}
