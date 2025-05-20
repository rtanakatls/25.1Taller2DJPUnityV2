using UnityEngine;

public class SonicMinigame5 : MonoBehaviour
{
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    private float currentSpeed;

    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d= GetComponent<Rigidbody2D>();
        currentSpeed=Random.Range(minSpeed,maxSpeed);
    }

    private void Update()
    {
        rb2d.linearVelocity = new Vector2(currentSpeed,0);
    }

}
