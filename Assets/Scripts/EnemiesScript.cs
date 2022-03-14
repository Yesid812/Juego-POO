using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemiesScript : MonoBehaviour
{
    public GameObject BulletPrefab; //Hacemos referencia al primer prefab de la bala
    public GameObject SpaceShip1;   //Hacemos referencia a la nave amiga
    private float LasShoot;
    private int Health = 3;
    public int Score;
    private void Update()
    {
        //Segmento de codigo que indica el seguimiento y deteccion de los enemigos hacia nuestro personajes.
        if (SpaceShip1==null) return;   
        float distance = Mathf.Abs(SpaceShip1.transform.position.y - transform.position.y);
        Vector3 Direction = SpaceShip1.transform.position - transform.position;
        if (Direction.y>= 0.0f) 
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        else
        {
            transform.localScale = new Vector3(1.0f,-1.0f,1.0f);
        }
        if(distance < 10.0f && Time.time > LasShoot + 0.99f)
        {
            Shoot();
            LasShoot= Time.time;
        }
        
    }

    //Metodo para disparar obteniendo el componente de la bala
    public void Shoot()
    {
        Vector3 direction = Vector3.down;
        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 1.8f, Quaternion.identity);
        bullet.GetComponent<BulletScritp>().setDirection(direction);
    }

    //Metodo que indica cuando la bala colisiona con los enemigos y que reduzca su vida
    public void Hit()
    {
        Health = Health - 1;
        if (Health == 0)
        {
            Destroy(gameObject);
            Score = +100;
        }
    }
    public int addScoreE1()
    {
        if (Health == 0)
        {
            Score += 100;
        }

        return Score;
    }
}