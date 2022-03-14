using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour
{
    public GameObject FlameBulletPrefab;
    public GameObject SpaceShip1;
    private float LasShoot;
    private int Health = 3;
    private void Update()
    {
        if (SpaceShip1 == null) return;
        float distance = Mathf.Abs(SpaceShip1.transform.position.y - transform.position.y);
        Vector3 Direction = SpaceShip1.transform.position - transform.position;
        if (Direction.y >= 0.0f)
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        else
        {
            transform.localScale = new Vector3(1.0f, -1.0f, 1.0f);
        }
        if (distance < 10.0f && Time.time > LasShoot + 0.99f)
        {
            Shoot();
            LasShoot = Time.time;
        }

    }

    public void Shoot()
    {
        Vector3 direction = Vector3.down;
        GameObject bullet = Instantiate(FlameBulletPrefab, transform.position + direction * 1.8f, Quaternion.identity);
        bullet.GetComponent<FlameBulletScript>().setDirection(direction);
    }
    public void Hit()
    {
        Health = Health - 1;
        if (Health == 0) Destroy(gameObject);
    }
}
