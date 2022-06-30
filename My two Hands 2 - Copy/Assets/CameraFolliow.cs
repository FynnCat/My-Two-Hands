using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolliow : MonoBehaviour
{
    public Transform player;
    public Camera _camera;
    public Vector3 offset, minValue, maxValue;
    public bool move;
    public float smoothFactor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        if (move == true)
        {
            Vector3 targetpos = player.position + offset;

            Vector3 boundpos = new Vector3(
               Mathf.Clamp(targetpos.x, minValue.y, maxValue.y),
               Mathf.Clamp(targetpos.x, minValue.z, maxValue.z),
               Mathf.Clamp(targetpos.x, targetpos.x, targetpos.x));

            Vector3 smoothpos = Vector3.Lerp(transform.position, targetpos, smoothFactor * Time.fixedDeltaTime);
            _camera.gameObject.transform.position = smoothpos;
        }
    }
}
