using UnityEngine;
using tabuleiro;
using xadrez;

class GameController2 : MonoBehaviour
{

    public GameObject reiPreto = null;

    PartidaDeXadrez partida;

    void Start()
    {
        partida = new PartidaDeXadrez();
        Util.instanciarRei('e', 8, Cor.Branca, partida, reiPreto);
    }
}
