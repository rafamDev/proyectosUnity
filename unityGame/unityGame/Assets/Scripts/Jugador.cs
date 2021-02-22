using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private Animator jugador;
    private Rigidbody2D cuerpoJugador;
    public float fuerzaSalto;
    
    void Start()
    {
        jugador = GetComponent<Animator>();
        cuerpoJugador = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si se presiona una tecla, le pasamos la tecla Space.
        if(Input.GetKeyDown(KeyCode.Space)){
            jugador.SetBool("estaSaltando",true);
            cuerpoJugador.AddForce(new Vector2(0,fuerzaSalto));
        }
    }

    //Esta funcion detecta si choca el jugador.
    private void OnCollisionEnter2D(Collision2D collision) {
        //Si choca..
        if(collision.gameObject.tag == "Suelo"){
            jugador.SetBool("estaSaltando",false);
        }
    }
}
