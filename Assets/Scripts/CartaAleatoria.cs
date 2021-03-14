using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaAleatoria : MonoBehaviour
{
    int naipeMinimo;
    int naipemaximo;
    int figuraMinima;
    int figuraMaxima;
    int nnaipe;
    int nfigura;
    string figura;
    string naipe;


    // Start is called before the first frame update
    void Start()
    {
        Iniciar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            CalculaEImprime();
        }
    }

    void CalculaEImprime()
    {
        nfigura = Random.Range(figuraMinima, figuraMaxima);
        nnaipe = Random.Range(naipeMinimo, naipemaximo);


        if (nfigura == 1)
        {
            figura = "Às";
        }

        else if (nfigura == 2)
        {
            figura = "Dois";
        }

        else if (nfigura == 3)
        {
            figura = "Três";
        }

        else if (nfigura == 4)
        {
            figura = "Quatro";
        }

        else if (nfigura == 5)
        {
            figura = "Cinco";
        }

        else if (nfigura == 6)
        {
            figura = "Seis";
        }

        else if (nfigura == 7)
        {
            figura = "Sete";
        }

        else if (nfigura == 8)
        {
            figura = "Oito";
        }

        else if (nfigura == 9)
        {
            figura = "Nove";
        }

        else if (nfigura == 10)
        {
            figura = "Dez";
        }

        else if (nfigura == 11)
        {
            figura = "Dama";
        }

        else if (nfigura == 12)
        {
            figura = "Valete";
        }

        else if (nfigura == 13)
        {
            figura = "Rei";
        }


        if (nnaipe == 1)
        {
            naipe = "Copas";
        }

        else if (nnaipe == 2)
        {
            naipe = "Espadas";
        }

        else if (nnaipe == 3)
        {
            naipe = "Paus";
        }

        else if (nnaipe == 4)
        {
            naipe = "Ouros";
        }

        Debug.Log("A carta que saiu foi " + figura + " de " + naipe + "!");

        Iniciar();
    }

    void Iniciar()
    {
        naipeMinimo = 1;
        naipemaximo = 4;
        figuraMinima = 1;
        figuraMaxima = 13;

        naipemaximo = naipemaximo + 1;
        figuraMaxima = figuraMaxima + 1;

        Debug.Log("Para tirares uma carta, clica na tecla espaço!");
    }
}
