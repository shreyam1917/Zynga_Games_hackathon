using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_bgd : MonoBehaviour
{
    public Renderer renders;
    public float speed;
    float counter = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * speed);
        renders.material.mainTextureOffset = offset;
        if (counter > 20)
        {
            speed += 0.01f;
        }

    }
}
