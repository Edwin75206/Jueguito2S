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
            if (scriptJugador.vidas <= 0){
                scriptJugador.Perdiste = true;
                scriptJugador.cuerpoJugador.constraints = RigidbodyConstraints2D.FreezeAll; 
            }else{
                scriptJugador.gameObject.transform.position = new Vector3(-9.3307f, 0.5114582f,0);    
            }
            
        }
        if(c1.tag == "Perro"){
            Destroy(c1.gameObject);
            //scriptJugador.gameObject.transform.position = new Vector3(-13.8f, 0.6f,0);
        }
    }

     void OnTriggerExit2D(Collider2D c2){
        if(c2.tag == "suelo"){
            scriptJugador.enSuelo = false;
        }
    }

}
