using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour{
    private Animator jugador;
    private Rigidbody2D cuerpoJugador;
    public float fuerzaSalto;
    public bool estaSuelo;
   
    protected void Start(){
        jugador = GetComponent<Animator>();
        cuerpoJugador = GetComponent<Rigidbody2D>();
    }

    protected void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && estaSuelo == true){
            jugador.SetBool("estaSaltando",true);
            cuerpoJugador.AddForce(new Vector2(0,fuerzaSalto));
            estaSuelo = false;
            fuerzaSalto = 0;
        }
    }
   
    private void OnCollisionStay2D(Collision2D other) {
        estaSuelo = true;
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Suelo"){
            fuerzaSalto = 500;
            jugador.SetBool("estaSaltando",false);
            estaSuelo = true;
        }
        if(collision.gameObject.tag == "Obstaculo"){
            GameManager.gameOver = true;
            jugador.speed = 0;
        }
    }

}
