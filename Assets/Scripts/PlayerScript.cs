using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour 
{
    public Rigidbody Rigidbody ;
    public float force = 1000f ;
    public float speed = 10f ;
    public float maxX  ;
    public float minX ;

    void Start() 
    {
        Debug.Log("Hello!");
    }

    void Update() 
    {   

        Vector3 playerpos = transform.position ;

        if(playerpos.x <= minX )
        {
            playerpos.x = minX ;
        }
        if(playerpos.x >= maxX )
        {
            playerpos.x = maxX ;
        }
        transform.position = playerpos ;
        if(Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D) )
        {
            transform.position = transform.position + new Vector3(speed*Time.deltaTime , 0 , 0 ) ;
            // Rigidbody.AddForce(1000f*Time.deltaTime , 0 , 0) ;
        }
        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A) )
        {
            transform.position = transform.position - new Vector3(speed*Time.deltaTime , 0 , 0 ) ;
            // Rigidbody.AddForce(-1000f*Time.deltaTime , 0 , 0) ;
        }
    }
    private void FixedUpdate()
    {
        Rigidbody.AddForce(0 , 0 , force*Time.deltaTime) ;
    }
}
