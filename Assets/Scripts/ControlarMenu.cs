using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ControlarMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameOverScript gameoverScreen;
    public TextMeshProUGUI ScoreTex;
    public GameObject enemiesScript;
    public void PauseButton()
    {
        PauseMenu.SetActive(true);//mostrar menu de pausa
        Time.timeScale = 0; //detenet el tiempo cuando el menu se activa
    }
    public void PlayButton()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;//no se detiene el tiempop en el juego
    }

    /**
     * se sale del juego al pulsar el botton
     */
    public void SalirButton()
    {
        Application.Quit();
       
    }

    /**
     * configurar teclas
     */
    private void Update()
    {
        ScoreTex.text = "Score: " ;
        if (Input.GetKey(KeyCode.Escape))
        {
            PauseButton(); //al precionar la tecla escape llama a la funcion de pausar el juego
        }
    }
    public void cargarMenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
