using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject spike;
    public float spawnRate = 2;
    public float timer = 0;
    
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
            timer = 0;
            spawnSpikes();
        }
        
    }

    void spawnSpikes()
    {
        Instantiate(spike,transform.position, transform.rotation);
    }
}
