using UnityEngine;

public class Food : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BottomCollider"))
        {
            GameObject.Find("Sonic").GetComponent<SonicMinigame1>().LostFood();
            Destroy(gameObject);
        }
    }
}
