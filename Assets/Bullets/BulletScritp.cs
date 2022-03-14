using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScritp : MonoBehaviour
{
    public float speed;
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;
    public AudioClip sound;
    void Start()
    {
        //Iniciamos los componente de colliders y de sonido
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        //Definimos el comportamiento de la bala
        Rigidbody2D.velocity = Direction*speed;
    }

    //Metodo para que indica la direccion de la bala
    public void setDirection(Vector2 direction) { 
        Direction = direction;
    }

    //Metodo para destruir la bala
    public void destroyBullet() { 
        Destroy(gameObject);
    }

    //Metodo que ayuda a destruir los enemigos haciendo uso de otros objetos y si chocamos con una bala
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ShipsScript Ship1 = collision.GetComponent<ShipsScript>();
        EnemiesScript enemy1 = collision.GetComponent<EnemiesScript>();
        Enemy2Script enemy2 = collision.GetComponent<Enemy2Script>();

        if (Ship1 != null)
        {
            Ship1.Hit();
        }
        if (enemy1 != null)
        {
            enemy1.Hit();
        }
        if(enemy2 != null)
        {
            enemy2.Hit();
        }
        destroyBullet();
    }
  
  
}
