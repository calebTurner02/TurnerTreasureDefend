using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    //destroy the bullet after 2 seconds so the game won't lag
    public void Start() 
    {
        Destroy(gameObject, 2f);
    }    

}
