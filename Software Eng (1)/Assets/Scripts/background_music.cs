/*
 * This script destroys the falling objects (spheres + images) 
 * after they pass the catcher. This is so their existance does
 * not imapct the game preformance
 * 
 * @author Jacob White (A00435401)
 * @author Naziya Tasnim (A00447506)
 */

// import
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// default unity class
public class background_music : MonoBehaviour
{
     // variables
     AudioSource fxSound; 
     
     public AudioClip backMusic; 
    // Use this for initialization
    void Start (){
     // play audio
        fxSound = GetComponent<AudioSource> ();
        fxSound.Play ();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
} // end
