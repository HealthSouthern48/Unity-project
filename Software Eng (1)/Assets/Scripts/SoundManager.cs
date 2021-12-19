/*
 * This script is used to adjust the audio levels
 * via the volume slider
 * 
 * @author Jacob White (A00435401)
 * @author Isaiah Jarvis (A00439675)
 */

//import
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// deafault unity class
public class SoundManager : MonoBehaviour
{
     // variable for the volume slider
     [SerializeField] Slider volumeSlider;
     // Start is called before the first frame update
     void Start()
     {
     }

     // Update is called once per frame
     public void ChangeVolume()
     {
          // sets audio volume to slider value
          AudioListener.volume = volumeSlider.value;
     }
}// end