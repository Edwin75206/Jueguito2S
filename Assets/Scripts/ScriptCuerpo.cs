using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCuerpo : MonoBehaviour
{
    
    public ScriptJugador scriptJugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
     void OnTriggerEnter2D(Collider2D c1){
        if(c1.tag == "Perro"){
            scriptJugador.vidas -- ;
            Debug.Log("Vidas: " + scriptJugador.vidas );

            if (scriptJugador.vidas <= 0){
                scriptJugador.Perdiste = true;
                scriptJugador.cuerpoJugador.constraints = RigidbodyConstraints2D.FreezeAll; 
            }else{
                scriptJugador.gameObject.transform.position = new Vector3(-9.3307f, 0.5114582f,0);    
            }


           // scriptJugador.canvas.gameObject.SetActive(true);
        }


        if(c1.tag == "Estrellita"){
            scriptJugador.estrellas ++ ;
            Debug.Log("Estrellas: " + scriptJugador.estrellas );
            Destroy(c1.gameObject);

            //scriptJugador.Perdiste = true;
            //scriptJugador.cuerpoJugador.constraints = RigidbodyConstraints2D.FreezeAll; 
        }
    }
}
