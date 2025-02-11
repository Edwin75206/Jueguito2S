using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScriptControl : MonoBehaviour
{
    public ScriptJugador scriptJugador;
    
    public AudioSource Musica;
    
    public GameObject[] NivelPreFab;
    public int indiceNivel;

    private GameObject Objetonivel;

    public Text textoPuntos;
    public Text textoVidas;
    public float tiempo = 0;
    public Text textoNivel;

    public Text textoTiempo;

    public GameObject canvasPause;

    public GameObject canvasPrincipal;
    public GameObject canvasGanaste;
    public GameObject canvasGameover;
    // Start is called before the first frame update
    void Start()
    {
        canvasPause.SetActive(false);
        canvasGameover.SetActive(false);
        canvasPrincipal.SetActive(false);
        canvasGanaste.SetActive(false);
        Objetonivel = Instantiate(NivelPreFab[indiceNivel]);
    Objetonivel.transform.SetParent(this.transform);

        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        textoTiempo.text = "Tiempo: " + tiempo.ToString("F2");

        // Verificar si el jugador ha perdido para activar Game Over
        if (scriptJugador.vidas <= 0)
        {
            GameOver();
        }

        if (scriptJugador.estrellas == 1)
        {
            WinnerGame();
        }
    }

    void FixedUpdate(){

        textoPuntos.text = "Puntos: " + scriptJugador.estrellas;
        textoVidas.text = "Vidas: " + scriptJugador.vidas;
        if(Input.GetKey(KeyCode.P)){
            PauseGame();
            Debug.Log("Presionando");
        }
    }

    public void PlayGame(){
        SceneManager.LoadSceneAsync(0);
    }

    public void PauseGame(){
        canvasPause.SetActive(true);
    }

    public void Reanudar(){
        canvasPause.SetActive(false);
        
    }


    public void GameOver(){
        canvasGameover.SetActive(true);
    }

    public void WinnerGame(){
        canvasGanaste.SetActive(true);
    }
}
