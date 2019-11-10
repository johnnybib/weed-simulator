using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeedController : MonoBehaviour
{
    [SerializeField]
    GameObject weedSplosion;

    [SerializeField]
    private float moveSpeed = 2.77778f;

    private Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.velocity = new Vector3(0, 0, -moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter (Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Instantiate(weedSplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
