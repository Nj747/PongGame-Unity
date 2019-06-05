using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPaletaDer : MonoBehaviour {

    private Rigidbody2D IA;

    public GameObject pelota;

    public float velocidad;

    public float lerpTweak = 0.5f; // suaviza el movimiento

    private void Awake()
    {
        IA = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        if (pelota.transform.position.y > IA.transform.position.y)
        {
            IA.velocity = Vector2.Lerp(IA.velocity, new Vector2(0,1).normalized * velocidad, lerpTweak * Time.deltaTime);
        }
        else 
        if (pelota.transform.position.y < IA.transform.position.y)
        {
            IA.velocity = Vector2.Lerp(IA.velocity, new Vector2(0, -1).normalized * velocidad, lerpTweak * Time.deltaTime);
            
        }
    }

}
