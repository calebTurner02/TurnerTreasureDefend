using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //The depth the player can fall before going to land
    public float threshold;
 
    void FixedUpdate ()
    {
        //Detects player position under land
        if (transform.position.y < threshold)
        transform.position = new Vector3(0, 0, 0);
    }         
}
