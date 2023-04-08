using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject shieldWall;
    public GameObject s1, s2;
    public GameObject spreadGun;
    public GameObject gun;
    public AudioSource sheildup;
    public AudioSource multishot;
    public AudioSource spreadshot;
    private void Start()
    {
        shieldWall.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        spreadGun.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ShieldWall")
        {
            s1.SetActive(false);
            s2.SetActive(false);
            spreadGun.SetActive(false);
            Destroy(collision.gameObject);
            shieldWall.SetActive(true);
            Invoke("DisableShieldWall", 10f);
            sheildup.Play();
        }
        if (collision.gameObject.tag == "MultiShoot")
        {
            shieldWall.SetActive(false);
            spreadGun.SetActive(false);
            Destroy(collision.gameObject);
            s1.SetActive(true);
            s2.SetActive(true);
            Invoke("DisableS1", 10f);
            Invoke("DisableS2", 10f);
            multishot.Play();
        }
        if (collision.gameObject.tag == "SpreadShoot")
        {
            s1.SetActive(false);
            s2.SetActive(false);
            shieldWall.SetActive(false);
            gun.SetActive(false);
            Destroy(collision.gameObject);
            spreadGun.SetActive(true);
            Invoke("DisableSpreadGun", 10f);
            spreadshot.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.tag == "ShieldWall")
        {
            s1.SetActive(false);
            s2.SetActive(false);
            spreadGun.SetActive(false);
            Destroy(collision.gameObject);
            shieldWall.SetActive(true);
            Invoke("DisableShieldWall", 10f);
        }
        if (collision.gameObject.tag == "MultiShoot")
        {
            shieldWall.SetActive(false);
            spreadGun.SetActive(false);
            Destroy(collision.gameObject);
            s1.SetActive(true);
            s2.SetActive(true);
            Invoke("DisableS1", 10f);
            Invoke("DisableS2", 10f);
        }
        if (collision.gameObject.tag == "SpreadShoot")
        {
            s1.SetActive(false);
            s2.SetActive(false);
            shieldWall.SetActive(false);
            gun.SetActive(false);
            Destroy(collision.gameObject);
            spreadGun.SetActive(true);
            Invoke("DisableSpreadGun", 10f);
        }*/
    }

    private void DisableS1()
    {
        s1.SetActive(false);
    }
    private void DisableS2()
    {
        s2.SetActive(false);
    }
    private void DisableShieldWall()
    {
        shieldWall.SetActive(false);
    }
    private void DisableGun()
    {
        gun.SetActive(false);
    }
    private void DisableSpreadGun()
    {
        spreadGun.SetActive(false);
    }
}

