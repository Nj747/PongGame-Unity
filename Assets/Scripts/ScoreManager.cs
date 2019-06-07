using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

    [Header("Cantidad de puntos a alcanzar para terminar el juego")]
    public int puntajeGanar;

    int puntajePJ, puntajeIA;

    public Text rightScoreUI;
    public Text leftScoreUI;

    // Update is called once per frame
    void Update ()
    {
        ActualizarPuntajes();
	    if (puntajeGanar == puntajeIA || puntajeGanar == puntajePJ)
        {
            Debug.Log("Fin del juego");
            Invoke("GameOver", 3); // espera 5 segundos y vuelve al menú principal
        }	
	}

    void ActualizarPuntajes()
    {
        puntajeIA = int.Parse(rightScoreUI.text);
        puntajePJ = int.Parse(rightScoreUI.text);
    }

    void GameOver()
    {
        SceneManager.LoadScene("Menu_Principal");
    }
}
