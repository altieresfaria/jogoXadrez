using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioUIController : MonoBehaviour {

	public void Jogar()
    {
        SceneManager.LoadScene("partida");
    }

    public void JPrologo()
    {
        SceneManager.LoadScene("prologo");
    }
}
