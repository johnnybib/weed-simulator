using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeederController : MonoBehaviour
{
    private float horz;
    private float vert;

    [SerializeField]
    private float moveSpeed = 1;

    private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");
        
        if(Mathf.Abs(horz) > 0)
        {
            body.velocity = new Vector3(moveSpeed * horz, 0, body.velocity.z);
        }
        else
        {
            body.velocity = new Vector3(0, 0, body.velocity.z);
        }

        if(Mathf.Abs(vert) > 0)
        {
            body.velocity = new Vector3(body.velocity.x, 0, moveSpeed * vert);        
        }
        else
        {
            body.velocity = new Vector3(body.velocity.x, 0, 0);        
        }
        
    }


}
