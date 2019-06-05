using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public float velocidad;

    // Update is called once per frame
    void Update () {
        float moveVert = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,moveVert) * velocidad;
	}
}
