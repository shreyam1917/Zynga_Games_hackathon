using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_mvmnt : MonoBehaviour
{
    public int health = 3;
    //spublic float shootspeed;
    public Rigidbody2D fire;
    public AudioSource destroySmall_medium;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2(transform.position.x, transform.position.y * shootspeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag=="Small_Medium" )
        {
            Spaceship_mvmnt.flag = 1;
            Destroy(collision.gameObject);
            Spaceship_mvmnt.score_value += 10;
            
        }

        if (gameObject.CompareTag("Large"))
        {
            health--;

            if (health <= 0)
            {
                Destroy(collision.gameObject);
                Spaceship_mvmnt.score_value += 20;

            }
        }
    }
}
