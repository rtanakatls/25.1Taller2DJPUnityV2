using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private float timer;
    [SerializeField] private float spawnTime;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= spawnTime)
        {
            timer = 0;
            GameObject obj=Instantiate(prefab);
            Vector2 position = transform.position;
            position.x = Random.Range(-2f, 2f);
            obj.transform.position = position;
        }
    }
}
