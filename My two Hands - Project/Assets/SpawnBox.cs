using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    [SerializeField] GameObject thing1;
    [SerializeField] bool _hasSpawned;

    void Awake()
    {
        GameObject thing = Instantiate(thing1) as GameObject;
        thing.transform.position = new Vector2(pointC.position.x, Random.Range(pointA.position.y, pointB.position.y));
    }
    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        if (_hasSpawned == false)
        {
            GameObject thing = Instantiate(thing1) as GameObject;
            thing.transform.position = new Vector2(pointC.position.x, Random.Range(pointA.position.y, pointB.position.y));
            _hasSpawned = true;
        }
    }
}
