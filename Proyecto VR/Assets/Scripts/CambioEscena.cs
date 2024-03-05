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
        // Obtén el índice de la escena actual y cárgala nuevamente
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
