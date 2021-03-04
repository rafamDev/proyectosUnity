using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private Animator jugador;
    private Rigidbody2D cuerpoJugador;
    public float fuerzaSalto;
    //public boolean estaSuelo;
    public int numero;
    
    protected void Start(){
        jugador = GetComponent<Animator>();
        cuerpoJugador = GetComponent<Rigidbody2D>();
    }

    protected void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            jugador.SetBool("estaSaltando",true);
            cuerpoJugador.AddForce(new Vector2(0,fuerzaSalto));
            // estaSuelo = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Suelo"){
            jugador.SetBool("estaSaltando",false);
            //estaSuelo = true;
        }
        if(collision.gameObject.tag == "Obstaculo"){
           GameManager.gameOver = true;
        }
    }
}
