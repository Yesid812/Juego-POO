using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameBulletScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;
    public AudioClip sound;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * speed;
    }

    public void setDirection(Vector2 direction)
    {
        Direction = direction;
    }

    public void destroyBullet()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         ShipsScript Ship1 = collision.GetComponent<ShipsScript>();
        if (Ship1 != null)
          {
                Ship1.Hit();
            destroyBullet();
        }
            
    }



}
