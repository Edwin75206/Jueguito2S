using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCamara : MonoBehaviour
{
    public float xMax; 
    public float yMax;
    public float xMin;
    public float yMin;
    public Transform blanco;

    // Start is called before the first frame update
    void Start()
    {
        blanco = GameObject.Find("Sancho").transform;
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position = new Vector3(Mathf.Clamp(blanco.position.x, xMin, xMax), Mathf.Clamp(blanco.position.y, yMin, yMax), blanco.position.z-1);
        
    }
}
