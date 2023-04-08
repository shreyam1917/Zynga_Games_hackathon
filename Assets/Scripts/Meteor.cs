using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public enum Size { Small, Medium, Large };
    public Size size;
    public float speed;
    float counter = 0;
    // Start is call before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > 10f)
        {
            speed += 10f;
            counter = 0;

        }
        counter = +Time.deltaTime;
    }
}
