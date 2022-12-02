using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerShooting : MonoBehaviour
{
    
    //The bullet that the player will shoot 
     public GameObject Bullet;
     //The launch velocity 
   public float launchVelocity = 700f;
   public float EnemyCounter = 0f; 
 
   void Update()
   {
    //Get the input for the shooting button 
       if (Input.GetButtonDown("Fire1"))
       {
           GameObject ball = Instantiate(Bullet, transform.position,  
                                                     transform.rotation);
           ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 
                                                (0, launchVelocity,0));
       }
   }
}


