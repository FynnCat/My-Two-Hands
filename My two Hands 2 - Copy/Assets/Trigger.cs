using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] Chunk _chunk;
    [SerializeField] CameraFolliow _camerFollow;
    [SerializeField] GameObject _spawnBox;
    // Start is called before the first frame update
    void Start()
    {
        _camerFollow = FindObjectOfType<CameraFolliow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered.");
        _chunk.SpawnChunk();
        _spawnBox.SetActive(true);
        
        _camerFollow.move = true;
    }
}

