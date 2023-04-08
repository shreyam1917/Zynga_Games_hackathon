using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float life = 3;
    public Sprite state1;
    public Sprite state2;
    public Animator Large_Anim;
    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Spaceship_mvmnt.score_value += 10;
        }
        if(collision.gameObject.tag == "Large")
        {
            //Destroy(collision.gameObject);
            
            
        }


   

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Large")
        {
            Spaceship_mvmnt.lifeOfLargemeteor--;
            Destroy(this.gameObject);
            if (Spaceship_mvmnt.lifeOfLargemeteor == 2)
            {
                collision.gameObject.GetComponent<SpriteRenderer>().sprite = state1;
                collision.gameObject.GetComponent<Animator>().enabled = false;
            }
            else if (Spaceship_mvmnt.lifeOfLargemeteor == 1)
            {
                collision.gameObject.GetComponent<SpriteRenderer>().sprite = state2;
            }
            if (Spaceship_mvmnt.lifeOfLargemeteor == 0)
            {
                Destroy(collision.gameObject);
                Spaceship_mvmnt.lifeOfLargemeteor = 3f;
                Spaceship_mvmnt.score_value += 20;
            }
        }
    }
}
