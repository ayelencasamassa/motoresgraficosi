using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJuego : MonoBehaviour
{
    public GameObject jugador;
    public GameObject bot;
    private List<GameObject> listaEnemigos = new List<GameObject>();
    float tiempoRestante;

    void Start()
    {
        ComenzarJuego();
    }

    void Update()
    {
        if (tiempoRestante==0)
        {
            ComenzarJuego();
        }
        
    }

    void CrearEnemigo()
    {
        foreach (GameObject item in listaEnemigos)
        {
            Destroy(item);
        }
       
        listaEnemigos.Add(Instantiate(bot, new Vector3(9, 1f, 3f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(7, 1f, 3f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(5, 1f, 3f), Quaternion.identity));

    }

    void ComenzarJuego()
    {
        jugador.transform.position = new Vector3(0f, 0f, 0f);
        StartCoroutine(ComenzarCronometro(60));
        CrearEnemigo();
    }
        
    public IEnumerator ComenzarCronometro(float valorCronometro = 60)
    {
        tiempoRestante = valorCronometro;
        while (tiempoRestante > 0)
        {
            Debug.Log("Restan " + tiempoRestante + " segundos.");
            yield return new WaitForSeconds(1.0f);
            tiempoRestante--;
             
        }
    }
}
