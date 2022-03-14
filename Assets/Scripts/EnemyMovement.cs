using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float velocidadX = 2;
    private float velocidadY = 1.5f;
    void Start()
    {
        
    }

    // Update is called once per frame y que define el movimiento haciendo uso de los margenes en pantalla
    void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime,0);
        if(( transform.position.x > 9) || (transform.position.x <-9))
        {
            velocidadX = -velocidadX;
        }
        if ((transform.position.y > 4) || (transform.position.y < -4))
        {
            velocidadY = -velocidadY;
        }
    }
}
