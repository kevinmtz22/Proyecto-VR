using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
 public GameObject ImagenFade;

    public void Cerrar(){
        Application.Quit();
    }

    public void Siguiente(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Anterior(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void aDonde(string NombreEscena){
        SceneManager.LoadScene(NombreEscena);
    }
    public void Desactivar(){
        ImagenFade.SetActive(false);
    }
    public void ReiniciarEscena()
    {
        // Obt�n el �ndice de la escena actual y c�rgala nuevamente
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
