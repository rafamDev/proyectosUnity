using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Renderer fondo;
    
    public GameObject objetoColumna;
    
    void Start()
    {
        //Crear Mapa (suelo) Infinito.
        //21 = numero de columnas, es decir 20 columnas.
        for(int i=0; i < 21; i++){
           Instantiate(objetoColumna, new Vector2(0 + i, 0), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
      fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.15f,0) * Time.deltaTime;
    }
}
