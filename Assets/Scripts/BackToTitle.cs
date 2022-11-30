using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{
  //Returns the player to the title screen when they click on the back button
    public void titleScreen()
  {
    //Takes player to scene 0 
    SceneManager.LoadScene(0);
  }
}
