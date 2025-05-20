using System.Collections.Generic;
using UnityEngine;

public class SwapController : MonoBehaviour
{
    [SerializeField] private List<GameObject> objects;

    private GameObject firstObject;
    private GameObject secondObject;
    private float timer;

    private Vector2 firstObjectTargetPosition;
    private Vector2 secondObjectTargetPosition;

    private int currentSwapNumbers;
    [SerializeField] private int maxSwapNumbers;

    private void Start()
    {
        timer = 10;
        GetSwap();
    }

    void Update()
    {
        if (currentSwapNumbers <= maxSwapNumbers)
        {
            if (timer > 1||firstObject==null||secondObject==null)
            {
                GetSwap();
            }
            else
            {
                firstObject.transform.position = Vector3.Lerp(secondObjectTargetPosition, firstObjectTargetPosition, timer);
                secondObject.transform.position = Vector3.Lerp(firstObjectTargetPosition, secondObjectTargetPosition, timer);
                timer += Time.deltaTime;
            }
        }
    }

    private void GetSwap()
    {
        firstObject = objects[Random.Range(0, objects.Count)];
        secondObject = objects[Random.Range(0, objects.Count)];

        if(firstObject!=secondObject)
        {
            timer = 0;
            firstObjectTargetPosition=secondObject.transform.position;
            secondObjectTargetPosition=firstObject.transform.position;
            currentSwapNumbers++;
        }
    }
}
