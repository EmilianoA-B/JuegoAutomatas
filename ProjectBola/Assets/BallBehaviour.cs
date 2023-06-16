using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallBehaviour : MonoBehaviour
{
    public LogicCode LogicCode;
    bool ballGround = false;
    bool ballAlive = true;
    public Rigidbody2D ballBody;
    public BoxCollider2D ground;
    public float Jump;

    private AudioSource oof;

    // Start is called before the first frame update
    void Start()
    {
        LogicCode = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) && ballAlive && ballGround) == true )
        {
            ballBody.velocity = new Vector2(0,1) * Jump;
            ballGround = false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballGround = true;
    }
    public void ballisDead()
    {
        ballAlive = false;
        oof = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 0)
        LogicCode.addPoint();
    }
}
