using UnityEngine;
using UnityEngine.SceneManagement; // para usar el SceneManager

public class Controlador : MonoBehaviour {

    public void CargarJuego()
    {
        SceneManager.LoadScene("Game");
    }
}
