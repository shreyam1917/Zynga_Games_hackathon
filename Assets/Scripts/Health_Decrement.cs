using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Decrement : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Health_Controller healthController = collision.GetComponent<Health_Controller>();
            healthController.TakeDamage();
        }
    }
}
