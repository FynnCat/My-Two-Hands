using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public float jumpForce;
    public float playerSpeed;
    public Vector2 jumpHeight;
    public Vector2 movementInput;
    [SerializeField] bool isOnGround;
    public float positionRadius;
    public LayerMask ground;
    public Transform playerPos;
    public PlayerInput playerInput;
    [SerializeField] int _playerIndex = 0;
    [SerializeField] bool jumpInput;



    public int GetPlayerIndex()
    {
        return _playerIndex;
    }

    // Start is called before the first frame update
    void Start()
    {

        playerInput = FindObjectOfType<PlayerInput>();
        Collider2D[] colliders = transform.GetComponentsInChildren<Collider2D>();
        for (int i = 0; i < colliders.Length; i++)
        {
            for (int k = i + 1; k < colliders.Length; k++)
            {
                Physics2D.IgnoreCollision(colliders[i], colliders[k]);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        playerInput.actions["Select"].performed += context => jumpInput = true;
        //playerInput = FindObjectOfType<PlayerInput>();
        if (movementInput.x != 0)
        {
            if (movementInput.x > 0)
            {
                anim.Play("Walk");
                rb.AddForce(Vector2.right * playerSpeed * Time.deltaTime);
            }

            else
            {
                anim.Play("WalkBack");
                rb.AddForce(Vector2.left * playerSpeed * Time.deltaTime);
            }
        }

        else
        {
            anim.Play("Idle");
        }

        isOnGround = Physics2D.OverlapCircle(playerPos.position, positionRadius, ground);

        if(isOnGround == true && jumpInput == true)
        {
            Debug.Log("jumping");
            rb.AddForce(Vector2.up * jumpForce * Time.deltaTime);
            jumpInput = false;
        }

        
    }

    public void OnMove(InputAction.CallbackContext ctx) => movementInput = ctx.ReadValue<Vector2>();


}
