using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject spike;
    public float spawnRate = 3;
    private float timer = 0;
    public float secondsUntilSpeedIncrease = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnSpikes();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
           
        }
        else if (timer > spawnRate)
        {
            spawnRate = Random.Range(1.5f, spawnRate + 2);
            timer = 0;
            spawnSpikes();
        }
    }

    
    void spawnSpikes()
    {   
        Instantiate(spike,transform.position, transform.rotation);
    }
}
