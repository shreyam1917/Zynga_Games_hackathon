using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodge_meteor : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Meteor" || collision.gameObject.tag == "Large")
        {
            Spaceship_mvmnt.score_value += 5;
            

        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Large")
        {
            Spaceship_mvmnt.lifeOfLargemeteor = 3;
        }
    }
}