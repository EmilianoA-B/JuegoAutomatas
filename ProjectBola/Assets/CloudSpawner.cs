using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float highestPoint = 1.3f;
    public float lowestPoint = -1.3f;
    public float spawnRate = 3;
    private float timer = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnRate)
        {
            timer = 0;
            spawnRate = Random.Range(1,2);
            spawnCloud();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    void spawnCloud()
    {
        Vector3 randominterval;
        randominterval = Vector3.up * Random.Range(highestPoint,lowestPoint);
        Instantiate(cloud,transform.position + randominterval, transform.rotation);
    }
}
