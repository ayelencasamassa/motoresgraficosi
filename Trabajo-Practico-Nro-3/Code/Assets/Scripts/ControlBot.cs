using UnityEngine;

public class ControlBot : MonoBehaviour
{
    private int hp;
    private GameObject jugador;
    public int rapidez;

    void Start()
    {
        hp = 100;
        jugador = GameObject.Find("Jugador");
    }

    private void Update()
    {
        transform.LookAt(jugador.transform);
        transform.Translate(rapidez * Vector3.forward * Time.deltaTime);
    }


    public void recibirDaño()
    {
        hp = hp - 25;

        if (hp<=0)
        {
            this.desaparecer();
        }
    }

    private void desaparecer()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            recibirDaño();
        }
    }
}
