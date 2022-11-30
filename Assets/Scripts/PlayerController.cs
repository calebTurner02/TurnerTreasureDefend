using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region "Variables"
    //get rigidbody 
    public Rigidbody Rigid;
    //Get mouse sensitivity 
    public float MouseSensitivity;

    //get move speed
    public float MoveSpeed;
    public float JumpForce;
    #endregion
   
   //Update the player movement when they press a key or look around with the mouse 
    void Update ()
    {
        Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0)));
        Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));
        if (Input.GetKeyDown("space"))
            Rigid.AddForce(transform.up * JumpForce);
    }
}
