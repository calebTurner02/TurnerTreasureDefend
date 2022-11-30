using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playGame : MonoBehaviour
{
    //Play game when click on play
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    //Takes player to how to play screen
    public void howToplay()
    {
       SceneManager.LoadScene(3); 
    }

//Takes player to controls screen
    public void Controls()
    {
        SceneManager.LoadScene(2); 
    }

//takes player to credits screen
     public void Credits()
    {
        SceneManager.LoadScene(4); 
    }
    
    
   
}
