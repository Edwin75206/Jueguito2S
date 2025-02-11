using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptTiempo : MonoBehaviour
{
    public ScriptJugador scriptJugador;
    public Text txtTiempo;
    // Start is called before the first frame update
    void Awake()
    {
        txtTiempo.text = "Tiempo: 0:00";
        scriptJugador = FindObjectOfType<ScriptJugador>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scriptJugador.Perdiste == false){
            txtTiempo.text = "Tiempo: " + FormatearTiempo();
        }
    }

    public string FormatearTiempo(){
        if(scriptJugador.Perdiste == false){
            scriptJugador.tiempo += Time.deltaTime;
        }

        string minutos = Mathf.Floor(scriptJugador.tiempo / 60).ToString("00");
        string segundos = Mathf.Floor(scriptJugador.tiempo % 60).ToString("00");

        return minutos + ":" + segundos;
    }
}
