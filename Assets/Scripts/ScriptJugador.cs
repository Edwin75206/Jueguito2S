using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptJugador : MonoBehaviour
{
    public float velocidad = 2;
    public float fuerzaSalto = 10;
    public bool enSuelo = false;

    public Animator miAnimacion;

    public bool MirandoDerecha = true;
    public Rigidbody2D cuerpoJugador;
    public int vidas = 3;
    public int estrellas = 0;

    public bool Perdiste = false;
    //public Canvas canvas;
    // Variable para el tiempo
    public float tiempo = 0;


    // Start is called before the first frame update
    void Start()
    {
        cuerpoJugador = GetComponent<Rigidbody2D>();
        
        //canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal"); //controlar movimiento horizontal
        miAnimacion.SetFloat("Velocidad", Mathf.Abs(horizontal));   //Este valor sale del animator para asi generar la funcion de que camine cada que alcance la velocidad dada
        miAnimacion.SetBool("Suelo", enSuelo);

        miAnimacion.SetBool("Perdiste", Perdiste);

        Voltear(horizontal);
        Mover();

    }

    private void Voltear(float horizontal){
        if(horizontal > 0 && !MirandoDerecha || horizontal < 0 && MirandoDerecha){
            MirandoDerecha = !MirandoDerecha;
            Vector3 LaEscala = transform.localScale;
            LaEscala.x *= -1;
            transform.localScale = LaEscala;
        }
    }

    public void Mover(){
        if(Input.GetKey("d") || Input.GetKey("right")){
            cuerpoJugador.velocity = new Vector2(velocidad, cuerpoJugador.velocity.y);
        } 
        else if (Input.GetKey("a") || Input.GetKey("left")){
            cuerpoJugador.velocity = new Vector2(-velocidad, cuerpoJugador.velocity.y);
        }

        if(Input.GetKey("space") && enSuelo){
            cuerpoJugador.velocity = new Vector2(cuerpoJugador.velocity.x, fuerzaSalto);
        }
    }
    
}
