using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    public float velocidad = 10;

    private Rigidbody2D pelota;
    private AudioSource audioSource;

    private void Awake()
    {
        pelota = GetComponent<Rigidbody2D>();
        pelota.velocity = Vector2.right * velocidad;
    }

    private void OnCollisionEnter2D(Collision2D obj)
    {
        /* checkear contra que objeto estoy colisionando
        para saber qué hacer en cada caso.*/

        // PaletaIzq o PaletaDer
        if (obj.gameObject.name == "PaletaIzq")
        {
            float y = (pelota.transform.position.y - obj.transform.position.y)/obj.collider.bounds.size.y;
            pelota.velocity = new Vector2(1, y).normalized * velocidad;
        }
        if (obj.gameObject.name == "PaletaDer")
        {
            float y = (pelota.transform.position.y - obj.transform.position.y) / obj.collider.bounds.size.y;
            pelota.velocity = new Vector2(-1, y).normalized * velocidad;
        }
        
        // ParedIzq o ParedDer
        if ((obj.gameObject.name == "ParedIzq") || (obj.gameObject.name == "ParedDer"))
        {
            // Actualizar puntaje del GUI
            // Play sound effect
        }
        // ParedInf o ParedSup
        if ((obj.gameObject.name == "ParedInf") || (obj.gameObject.name == "ParedSup"))
        {
            // Play sound effect
        }
    }
}
