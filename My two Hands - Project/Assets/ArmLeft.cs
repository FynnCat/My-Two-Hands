using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArmLeft : MonoBehaviour
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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            isPressed = true;
        }

        else {isPressed = false; }
        /*input.actions["Grab"].started += context => isPressed = true;
        input.actions["Grab"].canceled += context => isPressed = false;*/
        // Vector3 playerpos = new Vector3(cam.ScreenToViewportPoint(Input.mousePosition).x, cam.ScreenToViewportPoint(Input.mousePosition).y, 0);
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         Vector3 mousepos = new Vector3(worldPosition.x, worldPosition.y, worldPosition.z = 0);
        //Vector3 difference = playerpos - transform.position;
        //float rotationZ = Mathf.Atan2(movementInput.x, -movementInput.y) * Mathf.Rad2Deg;
        if (isPressed)
        {
            //Debug.Log(mousepos);
            rb.MoveRotation((Mathf.LerpAngle(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, speed * Time.deltaTime)));
        }
    }

   // public void OnMove(InputAction.CallbackContext ctx) => movementInput = ctx.ReadValue<Vector2>();
    }

