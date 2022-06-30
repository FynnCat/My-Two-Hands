using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    [SerializeField] GameObject thing1;

    void Awake()
    {
        GameObject thing = Instantiate(thing1) as GameObject;
        thing.transform.position = new Vector2(pointC.position.x, Random.Range(pointA.position.y, pointB.position.y));
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject thing = Instantiate(thing1) as GameObject;
            thing.transform.position = new Vector2(pointC.position.x, Random.Range(pointA.position.y, pointB.position.y));
        }
    }
}
