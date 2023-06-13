using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallBehaviour : MonoBehaviour
{
    bool ballGround = true;
    bool ballAlive = true;
    public Rigidbody2D ballBody;
    public BoxCollider2D ground;
    public float Jump;
    // Start is called before the first frame update
    void Start()
    {
        
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ballGround = true;
    }
}
