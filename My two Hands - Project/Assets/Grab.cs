using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grab : MonoBehaviour
{
    [SerializeField] bool holdright;
    [SerializeField] bool holdleft;
    public PlayerInput input;
    [SerializeField] GameObject _rbleft; 
    [SerializeField] GameObject _rbright;
    [SerializeField] FixedJoint2D fjleft;
    [SerializeField] FixedJoint2D fjright;
    [SerializeField] Rigidbody2D rbleft;
    [SerializeField] Rigidbody2D rbright;
    [SerializeField] Rigidbody2D rbRope;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            holdleft = true;
        }
        else
        {
            holdleft = false;
        }
        
        input.actions["Grab"].started += context => holdright = true;
        input.actions["Grab"].canceled += context => holdright = false;
        
    }

    void OnCollisionStay2D(Collision2D other)
    {

        Debug.Log("Col");
        if (holdleft == true)
        {
            if (other.gameObject == _rbleft.gameObject)
            {
                Rigidbody2D rb = _rbleft.gameObject.GetComponent<Rigidbody2D>();

                fjleft.connectedBody = rbRope;
            }
        }

         if (holdright == true)
        {
            if (other.gameObject == _rbright.gameObject)
            {
                Debug.Log("Testing.");
                fjright.connectedBody = rbRope;
                //rbright.gameObject.transform.position = gameObject.transform.position;


            }
        }

        else 
        {
            fjright.connectedBody = rbright;
            fjleft.connectedBody = rbleft;
        }

    }
}
