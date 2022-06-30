using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerinputHandler : MonoBehaviour
{

    [SerializeField] PlayerInput _playerInput;
    [SerializeField] Arms _arms;
void Awake()
{
    _playerInput = GetComponent<PlayerInput>();
    var index = _playerInput.playerIndex;
    var Arms = FindObjectsOfType<Arms>();
    _arms = Arms.FirstOrDefault(m => m.GetPlayerIndex() == index);
    
    
}
public void OnMove(InputAction.CallbackContext ctx) => _arms.movementInput = ctx.ReadValue<Vector2>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
