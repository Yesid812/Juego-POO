using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public Renderer Fondo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        //Metodo que hace el movimiento del fondo
        Fondo.material.mainTextureOffset = Fondo.material.mainTextureOffset + new Vector2(0.18f, 0) * Time.deltaTime;
    }
    // Metodos que cargan las escenas al presionar un boton del menu principal
    public void EscenaJuegoPrincipal()
    {
        SceneManager.LoadScene("ScenaJuego");
      
    }
    public void CargarOpciones( string cargarOpcion)
    {
        SceneManager.LoadScene(cargarOpcion);
    }
    public void SalirJuego()
    {
        Application.Quit();
    }
}
