/*
 * This script is to move the catcher
 * 
 * @author Jacob White (A00435401)
 */

//import
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// default unity class
public class move : MonoBehaviour {
    // set the movement speed of the catcher (in float)
    public float moveSpeed = 10f;
    // Use this for initialization
    void Start () {
   
    }
   
    // Update is called once per frame
    void Update ()
    {
        // if the user presses the left arrow key
    if(Input.GetKey(KeyCode.LeftArrow)){ // move the object if the .{key} is pressed

        //Moves left (says right because mirrored view)
            this.transform.Translate(Vector3.right * moveSpeed *Time.deltaTime);  

    }
    // if the user presses the right arrow key
    if(Input.GetKey(KeyCode.RightArrow)){ // move the object if the .{key} is pressed

        //Moves right (says left bc mirrored view)
            this.transform.Translate(Vector3.left * moveSpeed *Time.deltaTime);  
    }
  }
}// end
