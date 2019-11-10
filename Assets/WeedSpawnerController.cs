using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeedSpawnerController : MonoBehaviour
{
    [SerializeField]
    private GameObject weed;

    [SerializeField]
    private float spawnRate = 1;

    private float elapsedTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(elapsedTime > 1/spawnRate)
        {
            Vector3 randPos = transform.position;
            randPos.x += Random.Range(-0.35f, 0.35f);
            Instantiate(weed, randPos, Quaternion.identity);
            elapsedTime = 0;
        }
        elapsedTime += Time.deltaTime;
    }
}
