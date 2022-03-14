using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipsScript : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D; // Creamos un objeto de tipo RigidBody
    private float Horizontal;
    private float Vertical;
    public GameObject BulletPrefab;
    private int Health = 5;
    public GameOverScript gameoverScreen;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>(); // Iniciamos el componente
    }
    // Update is called once per frame
    void Update()

    {
        //Checamos repetidamente si el jugador presiona una tecla
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space)) {
            Shoot();
        }

       
    }

    //Metodo para disparar haciendo uso del script de la bala
    private void Shoot()
    {
        Vector3 direction = Vector3.up;
       GameObject bullet = Instantiate(BulletPrefab,transform.position + direction * 1.8f,Quaternion.identity);
        bullet.GetComponent<BulletScritp>().setDirection(direction);
;    }
    private void FixedUpdate() 
    {
       Rigidbody2D.velocity = new Vector2(Horizontal*6, Vertical*6);
    }

    //Metodo para detectar si recibimos un impacto de bala para que nuestra vida se reduzca
    public void Hit()
    {
        Health = Health - 1;
        if (Health == 0)
        {
            Destroy(gameObject);
            gameOver();
        }
    }
    //Metodo que aparece al morir
    public void gameOver()
    {
        gameoverScreen.setup(Health);
    }
}
