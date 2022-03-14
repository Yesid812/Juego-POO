using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Renderer BackGround;
    // Start is called before the first frame update
    public Renderer fondo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BackGround.material.mainTextureOffset = BackGround.material.mainTextureOffset + new Vector2(0.08f,0) * Time.deltaTime;
    }
    
}
