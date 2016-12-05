using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class PrologoUIController : MonoBehaviour
{

    int PaginaAtual;
    int N;
    List<GameObject> paginas;

    void Start()
    {
        PaginaAtual = 0;
        N = 1;
        paginas = new List<GameObject>();

        GameObject obj = GameObject.Find("pag0");
        paginas.Add(obj);
        obj = GameObject.Find("pag" + N);
        while (obj != null)
        {
            paginas.Add(obj);
            obj.SetActive(false);
            N++;
            obj = GameObject.Find("pag" + N);

        }

    }

    int proxima (int i)
    {
        return (i == N - 1) ? 0 : i + 1;
        }
        
    int anterior (int i){

        return (i == 0) ?  N - 1 : i - 1;
    }

    public void avancarPagina()
    {
        paginas[PaginaAtual].SetActive(false);
        PaginaAtual = proxima(PaginaAtual);
        paginas[PaginaAtual].SetActive(true); 
    }
    public void voltarPagina()
    {
        paginas[PaginaAtual].SetActive(false);
        PaginaAtual = anterior(PaginaAtual);
        paginas[PaginaAtual].SetActive(true);
    }

    public void Sair()
    {
        SceneManager.LoadScene("inicio");
    }
}
