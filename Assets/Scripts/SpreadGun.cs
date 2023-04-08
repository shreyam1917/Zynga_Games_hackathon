using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadGun : MonoBehaviour
{
    public Transform bulletSpawnPoint1, bulletSpawnPoint2, bulletSpawnPoint3, bulletSpawnPoint4, bulletSpawnPoint5;
    public GameObject bulletPrefab;
    public GameObject yellowbullet;
    public GameObject greenbullte;
    public GameObject redbullet;
    public GameObject blue;
    public float bulletSpeed = 10;
    public AudioSource BulletShoot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet1 = Instantiate(bulletPrefab, bulletSpawnPoint1.position, bulletSpawnPoint1.rotation);
            bullet1.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint1.up * bulletSpeed;
            var bullet2 = Instantiate(yellowbullet, bulletSpawnPoint2.position, bulletSpawnPoint2.rotation);
            bullet2.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint2.up * bulletSpeed;
            var bullet3 = Instantiate(greenbullte, bulletSpawnPoint3.position, bulletSpawnPoint3.rotation);
            bullet3.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint3.up * bulletSpeed;
            var bullet4 = Instantiate(redbullet, bulletSpawnPoint4.position, bulletSpawnPoint4.rotation);
            bullet4.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint4.up * bulletSpeed;
            var bullet5 = Instantiate(blue, bulletSpawnPoint5.position, bulletSpawnPoint5.rotation);
            bullet5.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint5.up * bulletSpeed;
            BulletShoot.Play();
        }           
    }

    /*public void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
    }*/
}
