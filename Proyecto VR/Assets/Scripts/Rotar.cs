using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public string nombreAnimacion;
    public Animator animator;

    public void ActivarRotacion(string nombreAnimacion)
    {
        
        // Activa la animación "rotar" en el animator
        animator.Play(nombreAnimacion);
    }

}