using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerinputHandler : MonoBehaviour
{

    [SerializeField] PlayerInput _playerInput;
    [SerializeField] PlayerController _playercontroller;
void Awake()
{
    _playerInput = GetComponent<PlayerInput>();
    var index = _playerInput.playerIndex;
        var players = FindObjectsOfType <PlayerController>();
    _playercontroller = players.FirstOrDefault(m => m.GetPlayerIndex() == index);
    
    
}


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
