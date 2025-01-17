using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptReiniciar : MonoBehaviour
{
    
    public void Restart(){
    Debug.Log("Botón de reinicio presionado");
        // Recarga la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }    

}
