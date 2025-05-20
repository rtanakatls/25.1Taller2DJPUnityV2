using UnityEngine;
using UnityEngine.SceneManagement;

public class RevealObject : MonoBehaviour
{
    public void OnMouseDown()
    {
        Destroy(GetComponent<SpriteRenderer>());
        Invoke("GameOver", 1f);
    }

    private void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
