using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{

    public Transform spawnpos;
    public GameObject chunk;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnChunk();
    }

    public void SpawnChunk()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spawn.");
                {
                GameObject thing = Instantiate(chunk) as GameObject;
                thing.transform.position = new Vector2(spawnpos.position.x, spawnpos.position.y);
            }
            
        }
        
    }
}
