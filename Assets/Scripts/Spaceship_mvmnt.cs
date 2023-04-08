using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spaceship_mvmnt : MonoBehaviour
{
    public TMP_Text score_text;
    public static int score_value = 0;
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float moveSpeed = 10f;
    public static float lifeOfLargemeteor= 3f;
    public AudioSource destroysound;
    public static int flag=0;
    public TMP_Text panelScore ;



    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        score_text.text = score_value.ToString();
        panelScore.text = score_value.ToString();
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, 0) * moveSpeed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
        }
        if (flag == 1)
        {
            destroysound.Play();
        }
        else
        {
            flag = 0;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Small_Medium")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
        if (collision.gameObject.tag == "Large")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
