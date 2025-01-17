using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEnemigo : MonoBehaviour
{

    public Rigidbody2D EnemigoBody;

    public float Velocidad;
    // Start is called before the first frame update
    void Start()
    {
        EnemigoBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemigoBody.velocity = new Vector2(-Velocidad, EnemigoBody.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D c1){
        if(c1.tag == "Borde"){
            Velocidad *= -1;
            Vector3 LaEscala = transform.localScale;
            LaEscala.x *=-1;
            transform.localScale = LaEscala;
        }
    }
}
