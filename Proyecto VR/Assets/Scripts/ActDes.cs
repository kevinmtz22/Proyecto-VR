using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActDes : MonoBehaviour
{
	//Este codigo va en el objeto vacio con box collider
	
	
	//public GameObject objetoACT;//Objeto que esta agarrando
	//public Renderer elcambio;
	public string LaEtiqueta;//la etiqueta que tiene el objeto que esta agarrando
	public GameObject objetoDES;//Objeto que esta desactivado pero se activara al hacer colision
	//public TMP_Text SinCanvas;
	//public string TextoAlPoner;
	//public string TextoAlQuitar;

	
	public void OnCollisionEnter (Collision collision){
	if(collision.gameObject.CompareTag(LaEtiqueta)){
	//elcambio.material=elEncendido;
    objetoDES.SetActive(true);
    //SinCanvas.text = TextoAlPoner;
    Destroy(collision.gameObject);
}
	else
	{
		//codigo para hacer prender el arduino
	}
}

    /*public void OnCollisionExit (Collision collision){
        if(collision.gameObject.CompareTag(LaEtiqueta)){
            //elcambio.material=elApagado;
            LaLuz.SetActive(false);
            SinCanvas.text = TextoAlQuitar;
    }
    }*/


}


