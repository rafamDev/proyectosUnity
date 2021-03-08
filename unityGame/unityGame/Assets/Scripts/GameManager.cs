using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{ 

    public Renderer fondo;
    public GameObject objetoColumna;
    public GameObject tronco;
    public List<GameObject> troncos;
    public static bool gameOver = false;
    public GameObject menuGameOver;

    protected void Start(){
       for(int i=0; i < 2; i++){
           Instantiate(objetoColumna, new Vector2(i + 1, 0), Quaternion.identity);
       }
       for(int i=1; i <= 40; i++){
           troncos.Add(Instantiate(tronco, new Vector2(i * 20,-2.00f), Quaternion.identity)); 
       }
    }

    protected void Update(){
      if(gameOver == false){ 
          fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.15f,0) * Time.deltaTime * 2;
             for(int i=0; i < troncos.Count; i++){
                 troncos[i].transform.position += new Vector3(-1,0,0) * Time.deltaTime * 6;
             }
      }
      if(gameOver == true){
         if(Input.GetKeyDown(KeyCode.X)){
             gameOver = false;
             menuGameOver.SetActive(false);
             SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
        menuGameOver.SetActive(true);
      }  
     
   }

}
