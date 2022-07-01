using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Arms : MonoBehaviour
{

    [SerializeField] int speed = 300;
    public Rigidbody2D rb;
    public Camera cam;
    public KeyCode mousebutton;
    public Vector2 movementInput;
    public bool isPressed;
    public PlayerInput input;
    [SerializeField] int _playerIndex = 0;

    

    // Start is called before the first frame update
    void Start()
    {
       input = GetComponent<PlayerInput>();
        
    }

    public int GetPlayerIndex()
    {
        return _playerIndex;
    }

    // Update is called once per frame
    void Update()
    {
        input.actions["Grab"].started += context => isPressed = true;
        input.actions["Grab"].canceled += context => isPressed = false;
        Vector3 playerpos = new Vector3(cam.ScreenToViewportPoint(Input.mousePosition).x, cam.ScreenToViewportPoint(Input.mousePosition).y, 0);
        Vector3 difference = playerpos - transform.position;
        float rotationZ = Mathf.Atan2(movementInput.x, -movementInput.y) * Mathf.Rad2Deg;
        if (isPressed)
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, rotationZ, speed * Time.fixedDeltaTime));
        }
    }

    public void OnMove(InputAction.CallbackContext ctx) => movementInput = ctx.ReadValue<Vector2>();
    

}
