using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    
    public Animator animator;

    public void ActivarRotacion()
    {
        // Activa la animaci�n "rotar" en el animator
        animator.Play("rotar");
    }
}