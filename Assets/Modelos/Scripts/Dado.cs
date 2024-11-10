using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Dado : MonoBehaviour
{
    [SerializeField] float puntos;
    [SerializeField] float vida;
    [SerializeField] int Resultado1 = 1;
    [SerializeField] int Resultado2 = 1;
    [SerializeField] int Resultado3 = 1;
    [SerializeField] bool resultado1Conseguido;
    [SerializeField] bool resultado2Conseguido;
    [SerializeField] bool resultado3Conseguido;
    [SerializeField] Vector3 posicionRespawn;
    [SerializeField] TMP_Text puntosTexto;
    [SerializeField] TMP_Text vidasTexto;
    [SerializeField] TMP_Text resultadoTirada;
    [SerializeField] Transform[] carasDado;
    [SerializeField] bool estaEnZonaTirada;
    [SerializeField] bool realizandoTirada1;
    [SerializeField] bool realizandoTirada2;
    [SerializeField] bool realizandoTirada3;
    [SerializeField] GameObject panelExplicacionTirada;
    [SerializeField] GameObject panelResultadoTirada;
    [SerializeField] GameObject recorrido1;
    [SerializeField] GameObject recorrido2;
    [SerializeField] GameObject recorrido3;
    [SerializeField] GameObject[] pruebas1;
    [SerializeField] GameObject[] pruebas2;
    [SerializeField] GameObject[] pruebas3;
    [SerializeField] AudioManager audioManager;
    [SerializeField] AudioClip[] sonidosDado;
    [SerializeField] GameManagerJuego gameManager;
    bool SonidoRoll1Reproducido;
    bool SonidoRoll2Reproducido;
    bool SonidoRoll3Reproducido;
    bool SonidoRoll4Reproducido;
    bool SonidoRoll5Reproducido;
    bool SonidoRoll6Reproducido;



    private Rigidbody rb;


    void Start()
    {
        posicionRespawn = transform.position;
        rb = GetComponent<Rigidbody>();
        vidasTexto.SetText("Vidas: " + vida);
        puntosTexto.SetText("Puntos: " + puntos);
    }


    void Update()
    {
        if (rb.angularVelocity.sqrMagnitude == 0 && estaEnZonaTirada)
        {
            AnalizarResultado();
            panelResultadoTirada.SetActive(true);
            EjecutarNuevoNivel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Completado"))
        {
            gameManager.LoadCompletado();

        } 
        
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            puntos += 100;
            puntosTexto.SetText("Puntos: " + puntos);

        }

        if (other.CompareTag("Trampa"))
        {
        
        }

        if (other.CompareTag("Vacio"))
        {
            transform.position = posicionRespawn + new Vector3(0, 1, 0);
            audioManager.ReproducirSonido(sonidosDado[15]);
            rb.velocity = new Vector3(0, 0, 0);
            vida -= 1;
            vidasTexto.SetText("Vidas: " + vida);
            if(vida<=0)
            {
                gameManager.LoadGameOver();
            }
        }

        if (other.CompareTag("Respawn"))
        {

            posicionRespawn = new Vector3(0, transform.position.y, transform.position.z);
            audioManager.ReproducirSonido(sonidosDado[16]);

        }

        if (other.CompareTag("Tirada1") && !resultado1Conseguido)
        {

            estaEnZonaTirada = true;
            realizandoTirada1 = true;
            if (!SonidoRoll1Reproducido)
            {
                audioManager.ReproducirSonido(sonidosDado[0]);
                SonidoRoll1Reproducido = true;
            }



        }

        if (other.CompareTag("Tirada2") && !resultado2Conseguido)
        {
            estaEnZonaTirada = true;
            realizandoTirada2 = true;
            if (!SonidoRoll2Reproducido)
            {
                audioManager.ReproducirSonido(sonidosDado[0]);
                SonidoRoll2Reproducido = true;
            }
        }
        if (other.CompareTag("Tirada3") && !resultado3Conseguido)
        {
            estaEnZonaTirada = true;
            realizandoTirada3 = true;
            if (!SonidoRoll3Reproducido)
            {
                audioManager.ReproducirSonido(sonidosDado[0]);
                SonidoRoll3Reproducido = true;
            }

        }

        //if (other.CompareTag("Plataforma"))
        //{ 
        //    transform.parent = other.transform;
        //    Debug.Log("han chocado");
        //}
    }


    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tirada1"))
        {
            estaEnZonaTirada = false;
            panelResultadoTirada.SetActive(false);
        }
        if (other.CompareTag("Tirada2"))
        {
            estaEnZonaTirada = false;
            panelResultadoTirada.SetActive(false);
        }
        if (other.CompareTag("Tirada3"))
        {
            estaEnZonaTirada = false;
            panelResultadoTirada.SetActive(false);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Plataforma"))
    //    {
    //        transform.parent = collision.transform;

    //    }


    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Plataforma"))
    //    {
    //        transform.parent = null;

    //    }


    //}
    void AnalizarResultado()
    {
        if (realizandoTirada1 && ! realizandoTirada2 && !realizandoTirada3)
        {
            for (int i = 0; i < carasDado.Length; i++)
            {
                if (carasDado[i].position.y > carasDado[Resultado1 - 1].position.y)
                {
                    Resultado1 = i + 1;
                }
            }
            if (!SonidoRoll4Reproducido)
            {
                audioManager.ReproducirSonido(sonidosDado[1]);
                SonidoRoll4Reproducido = true;
            }
            resultadoTirada.SetText("Has sacado un: " + Resultado1 + " veamos que te depara el proximo nivel.");
            resultado1Conseguido = true;
        }
        else if (realizandoTirada1 && realizandoTirada2 &&!realizandoTirada3)
        {
            for (int i = 0; i < carasDado.Length; i++)
            {
                if (carasDado[i].position.y > carasDado[Resultado2 - 1].position.y)
                {
                    Resultado2 = i + 1;
                }
            }
            if (!SonidoRoll5Reproducido)
            {
                audioManager.ReproducirSonido(sonidosDado[1]);
                SonidoRoll5Reproducido = true;
            }
            resultadoTirada.SetText("Has sacado un: " + Resultado2 + " veamos que te depara el proximo nivel.");
            resultado2Conseguido = true;
        }
        else if (realizandoTirada1 && realizandoTirada2 && realizandoTirada3)
        {
            for (int i = 0; i < carasDado.Length; i++)
            {
                if (carasDado[i].position.y > carasDado[Resultado3 - 1].position.y)
                {
                    Resultado3 = i + 1;
                }
            }
            if (!SonidoRoll6Reproducido)
            {
                audioManager.ReproducirSonido(sonidosDado[1]);
                SonidoRoll6Reproducido = true;
            }
            resultadoTirada.SetText("Has sacado un: " + Resultado3 + " veamos que te depara el proximo nivel.");
            resultado3Conseguido = true;
        }
    }
    void EjecutarNuevoNivel()
    {

        if (resultado1Conseguido && !resultado2Conseguido &&!resultado3Conseguido)
        {
            recorrido1.SetActive(true);
            if (Resultado1 == 1)
            {
                pruebas1[0].SetActive(true);
                pruebas1[3].SetActive(true);
                pruebas1[6].SetActive(true);
            }
            else if (Resultado1 == 2)
            {
                pruebas1[0].SetActive(true);
                pruebas1[3].SetActive(true);
                pruebas1[7].SetActive(true);
            }
            else if (Resultado1 == 3)
            {
                pruebas1[0].SetActive(true);
                pruebas1[3].SetActive(true);
                pruebas1[8].SetActive(true);
            }
            else if (Resultado1 == 4)
            {
                pruebas1[0].SetActive(true);
                pruebas1[4].SetActive(true);
                pruebas1[6].SetActive(true);
            }
            else if (Resultado1 == 5)
            {
                pruebas1[0].SetActive(true);
                pruebas1[4].SetActive(true);
                pruebas1[7].SetActive(true);
            }
            else if (Resultado1 == 6)
            {
                pruebas1[0].SetActive(true);
                pruebas1[4].SetActive(true);
                pruebas1[8].SetActive(true);
            }
            else if (Resultado1 == 7)
            {
                pruebas1[0].SetActive(true);
                pruebas1[5].SetActive(true);
                pruebas1[6].SetActive(true);
            }
            else if (Resultado1 == 8)
            {
                pruebas1[0].SetActive(true);
                pruebas1[5].SetActive(true);
                pruebas1[7].SetActive(true);
            }
            else if (Resultado1 == 9)
            {
                pruebas1[1].SetActive(true);
                pruebas1[5].SetActive(true);
                pruebas1[8].SetActive(true);
            }
            else if (Resultado1 == 10)
            {
                pruebas1[1].SetActive(true);
                pruebas1[3].SetActive(true);
                pruebas1[6].SetActive(true);
            }
            else if (Resultado1 == 11)
            {
                pruebas1[1].SetActive(true);
                pruebas1[3].SetActive(true);
                pruebas1[7].SetActive(true);
            }
            else if (Resultado1 == 12)
            {
                pruebas1[1].SetActive(true);
                pruebas1[3].SetActive(true);
                pruebas1[8].SetActive(true);
            }
            else if (Resultado1 == 13)
            {
                pruebas1[1].SetActive(true);
                pruebas1[4].SetActive(true);
                pruebas1[6].SetActive(true);
            }
            else if (Resultado1 == 14)
            {
                pruebas1[1].SetActive(true);
                pruebas1[4].SetActive(true);
                pruebas1[7].SetActive(true);
            }
            else if (Resultado1 == 15)
            {
                pruebas1[2].SetActive(true);
                pruebas1[3].SetActive(true);
                pruebas1[6].SetActive(true);
            }
            else if (Resultado1 == 16)
            {
                pruebas1[2].SetActive(true);
                pruebas1[3].SetActive(true);
                pruebas1[7].SetActive(true);
            }
            else if (Resultado1 == 17)
            {
                pruebas1[2].SetActive(true);
                pruebas1[4].SetActive(true);
                pruebas1[8].SetActive(true);
            }
            else if (Resultado1 == 18)
            {
                pruebas1[2].SetActive(true);
                pruebas1[4].SetActive(true);
                pruebas1[6].SetActive(true);
            }
            else if (Resultado1 == 19)
            {
                pruebas1[2].SetActive(true);
                pruebas1[4].SetActive(true);
                pruebas1[7].SetActive(true);
            }
            else if (Resultado1 == 20)
            {
                pruebas1[2].SetActive(true);
                pruebas1[5].SetActive(true);
                pruebas1[6].SetActive(true);
            }

        }

        else if (resultado1Conseguido && resultado2Conseguido && !resultado3Conseguido)
        {
            recorrido2.SetActive(true);
            if (Resultado1 == 1)
            {
                pruebas2[0].SetActive(true);
                pruebas2[3].SetActive(true);
                pruebas2[6].SetActive(true);
            }          
            else if (Resultado1 == 2)
            {          
                pruebas2[0].SetActive(true);
                pruebas2[3].SetActive(true);
                pruebas2[7].SetActive(true);
            }          
            else if (Resultado1 == 3)
            {          
                pruebas2[0].SetActive(true);
                pruebas2[3].SetActive(true);
                pruebas2[8].SetActive(true);
            }          
            else if (Resultado1 == 4)
            {          
                pruebas2[0].SetActive(true);
                pruebas2[4].SetActive(true);
                pruebas2[6].SetActive(true);
            }          
            else if (Resultado1 == 5)
            {          
                pruebas2[0].SetActive(true);
                pruebas2[4].SetActive(true);
                pruebas2[7].SetActive(true);
            }          
            else if (Resultado1 == 6)
            {          
                pruebas2[0].SetActive(true);
                pruebas2[4].SetActive(true);
                pruebas2[8].SetActive(true);
            }          
            else if (Resultado1 == 7)
            {          
                pruebas2[0].SetActive(true);
                pruebas2[5].SetActive(true);
                pruebas2[6].SetActive(true);
            }          
            else if (Resultado1 == 8)
            {          
                pruebas2[0].SetActive(true);
                pruebas2[5].SetActive(true);
                pruebas2[7].SetActive(true);
            }          
            else if (Resultado1 == 9)
            {          
                pruebas2[1].SetActive(true);
                pruebas2[5].SetActive(true);
                pruebas2[8].SetActive(true);
            }          
            else if (Resultado1 == 10)
            {          
                pruebas2[1].SetActive(true);
                pruebas2[3].SetActive(true);
                pruebas2[6].SetActive(true);
            }          
            else if (Resultado1 == 11)
            {          
                pruebas2[1].SetActive(true);
                pruebas2[3].SetActive(true);
                pruebas2[7].SetActive(true);
            }          
            else if (Resultado1 == 12)
            {          
                pruebas2[1].SetActive(true);
                pruebas2[3].SetActive(true);
                pruebas2[8].SetActive(true);
            }          
            else if (Resultado1 == 13)
            {          
                pruebas2[1].SetActive(true);
                pruebas2[4].SetActive(true);
                pruebas2[6].SetActive(true);
            }          
            else if (Resultado1 == 14)
            {          
                pruebas2[1].SetActive(true);
                pruebas2[4].SetActive(true);
                pruebas2[7].SetActive(true);
            }          
            else if (Resultado1 == 15)
            {          
                pruebas2[2].SetActive(true);
                pruebas2[3].SetActive(true);
                pruebas2[6].SetActive(true);
            }          
            else if (Resultado1 == 16)
            {          
                pruebas2[2].SetActive(true);
                pruebas2[3].SetActive(true);
                pruebas2[7].SetActive(true);
            }          
            else if (Resultado1 == 17)
            {          
                pruebas2[2].SetActive(true);
                pruebas2[4].SetActive(true);
                pruebas2[8].SetActive(true);
            }          
            else if (Resultado1 == 18)
            {          
                pruebas2[2].SetActive(true);
                pruebas2[4].SetActive(true);
                pruebas2[6].SetActive(true);
            }          
            else if (Resultado1 == 19)
            {          
                pruebas2[2].SetActive(true);
                pruebas2[4].SetActive(true);
                pruebas2[7].SetActive(true);
            }          
            else if (Resultado1 == 20)
            {          
                pruebas2[2].SetActive(true);
                pruebas2[5].SetActive(true);
                pruebas1[6].SetActive(true);
            }
        }

        else if (resultado1Conseguido && resultado2Conseguido && resultado3Conseguido)
        {
            recorrido3.SetActive(true);
            if (Resultado1 == 1)
            {
                pruebas3[0].SetActive(true);
                pruebas3[3].SetActive(true);
                pruebas3[6].SetActive(true);
            }          
            else if (Resultado1 == 2)
            {
                pruebas3[0].SetActive(true);
                pruebas3[3].SetActive(true);
                pruebas3[7].SetActive(true);
            }
            else if (Resultado1 == 3)
            {
                pruebas3[0].SetActive(true);
                pruebas3[3].SetActive(true);
                pruebas3[8].SetActive(true);
            }
            else if (Resultado1 == 4)
            {
                pruebas3[0].SetActive(true);
                pruebas3[4].SetActive(true);
                pruebas3[6].SetActive(true);
            }
            else if (Resultado1 == 5)
            {
                pruebas3[0].SetActive(true);
                pruebas3[4].SetActive(true);
                pruebas3[7].SetActive(true);
            }
            else if (Resultado1 == 6)
            {
                pruebas3[0].SetActive(true);
                pruebas3[4].SetActive(true);
                pruebas3[8].SetActive(true);
            }
            else if (Resultado1 == 7)
            {          
                pruebas3[0].SetActive(true);
                pruebas3[5].SetActive(true);
                pruebas3[6].SetActive(true);
            }
            else if (Resultado1 == 8)
            {
                pruebas3[0].SetActive(true);
                pruebas3[5].SetActive(true);
                pruebas3[7].SetActive(true);
            }
            else if (Resultado1 == 9)
            {
                pruebas3[1].SetActive(true);
                pruebas3[5].SetActive(true);
                pruebas3[8].SetActive(true);
            }
            else if (Resultado1 == 10)
            {
                pruebas3[1].SetActive(true);
                pruebas3[3].SetActive(true);
                pruebas3[6].SetActive(true);
            }
            else if (Resultado1 == 11)
            {
                pruebas3[1].SetActive(true);
                pruebas3[3].SetActive(true);
                pruebas3[7].SetActive(true);
            }
            else if (Resultado1 == 12)
            {
                pruebas3[1].SetActive(true);
                pruebas3[3].SetActive(true);
                pruebas3[8].SetActive(true);
            }
            else if (Resultado1 == 13)
            {
                pruebas3[1].SetActive(true);
                pruebas3[4].SetActive(true);
                pruebas3[6].SetActive(true);
            }
            else if (Resultado1 == 14)
            {
                pruebas3[1].SetActive(true);
                pruebas3[4].SetActive(true);
                pruebas3[7].SetActive(true);
            }
            else if (Resultado1 == 15)
            {
                pruebas3[2].SetActive(true);
                pruebas3[3].SetActive(true);
                pruebas3[6].SetActive(true);
            }
            else if (Resultado1 == 16)
            {
                pruebas3[2].SetActive(true);
                pruebas3[3].SetActive(true);
                pruebas3[7].SetActive(true);
            }
            else if (Resultado1 == 17)
            {
                pruebas3[2].SetActive(true);
                pruebas3[4].SetActive(true);
                pruebas3[8].SetActive(true);
            }
            else if (Resultado1 == 18)
            {
                pruebas3[2].SetActive(true);
                pruebas3[4].SetActive(true);
                pruebas3[6].SetActive(true);
            }
            else if (Resultado1 == 19)
            {
                pruebas3[2].SetActive(true);
                pruebas3[4].SetActive(true);
                pruebas3[7].SetActive(true);
            }
            else if (Resultado1 == 20)
            {
                pruebas3[2].SetActive(true);
                pruebas3[5].SetActive(true);
                pruebas3[6].SetActive(true);
            }
        }
    }
}
        


    
