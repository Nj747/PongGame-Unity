using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola : MonoBehaviour {

    public float velocidad = 10;

    private Rigidbody2D pelota;
    private AudioSource audioSource;

    public Text rightScoreUI;
    public Text leftScoreUI;

    private void Awake()
    {
        pelota = GetComponent<Rigidbody2D>();
        pelota.velocity = Vector2.right * velocidad;
    }

    private void OnCollisionEnter2D(Collision2D obj)
    {
        /* checkear contra que objeto estoy colisionando
        para saber qué hacer en cada caso.*/
        float y = (pelota.transform.position.y - obj.transform.position.y) / obj.collider.bounds.size.y;
        // PaletaIzq o PaletaDer
        if (obj.gameObject.name == "PaletaIzq")
        {   
            pelota.velocity = new Vector2(1, y).normalized * velocidad;
        }
        if (obj.gameObject.name == "PaletaDer")
        {
            pelota.velocity = new Vector2(-1, y).normalized * velocidad;
        }
        
        // ParedIzq o ParedDer
        if (obj.gameObject.name == "ParedIzq")
        {
            // Actualizar RightScoreUI
            // Play sound effect
            rightScoreUI.text = IncrementarPuntaje(rightScoreUI.text);
        }

        if (obj.gameObject.name == "ParedDer")
        {
            // Actualizar LeftScoreUI
            // Play sound effect
            leftScoreUI.text = IncrementarPuntaje(leftScoreUI.text);
        }

        // ParedInf o ParedSup
        if ((obj.gameObject.name == "ParedInf") || (obj.gameObject.name == "ParedSup"))
        {
            // Play sound effect
        }
    }

    
    string IncrementarPuntaje(string puntaje)
    {
        int p = int.Parse(puntaje);
        p++;
        return p.ToString();
    }
}
