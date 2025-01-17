using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptPiesJugador : MonoBehaviour
{
    public ScriptJugador scriptJugador;
    
    
     void OnTriggerEnter2D(Collider2D c1){
        if(c1.tag == "suelo"){
            scriptJugador.enSuelo = true;
        } 
        if(c1.tag == "Agua"){
            scriptJugador.vidas -- ;
            Debug.Log("Vidas: " + scriptJugador.vidas );
            scriptJugador.Perdiste = true;
            scriptJugador.cuerpoJugador.constraints = RigidbodyConstraints2D.FreezeAll; 
        }
        if(c1.tag == "Perro"){
            Destroy(c1.gameObject);
        }
    }

     void OnTriggerExit2D(Collider2D c2){
        if(c2.tag == "suelo"){
            scriptJugador.enSuelo = false;
        }
    }

}
