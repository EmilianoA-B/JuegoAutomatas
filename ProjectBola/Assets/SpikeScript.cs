using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    private AudioSource oof;
    public AudioClip soundOof;
    public float volume;

    public LogicCode logic;
    // Start is called before the first frame update
    void Start()
    {

        oof = GetComponent<AudioSource>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        oof.clip = soundOof;
        oof.Play();
    }
}
