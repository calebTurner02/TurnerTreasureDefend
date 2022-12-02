using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDestroyer : MonoBehaviour
{
   [SerializeField] int Enemyleft = 0;
   
 void OnCollisionEnter(Collision other) 
{
   //Count all the targets the player has to shoot
   
   

   if(tag == "Enemy")
   {
      //Subtract the targets after the player shoots them
      Enemyleft--;
      //destroy the gameobject
      Destroy(this.gameObject); 
      //destroy the bullet
     Destroy(other.gameObject);
      if(Enemyleft == 0)
      {
         SceneManager.LoadScene(5);
      }
         
      }
   }

 

  
}


