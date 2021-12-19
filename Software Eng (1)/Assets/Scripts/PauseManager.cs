/*
 * This script is to pause/ unpause the game
 * 
 * @author Jacob White (A00435401)
 * @author Isaiah Jarvis (A00439675)
 */

//import
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// default unity class
public class PauseManager : MonoBehaviour
{
     // variables
     [SerializeField] Button pauseButton;
     private UnityEngine.UI.Text TextBox1; // textbox
     string pause, unpause;
     // Start is called before the first frame update
     void Start()
     {
          // set variables
          TextBox1 = GameObject.Find("PauseText").GetComponent<UnityEngine.UI.Text>();
          pause = "Pause";
          unpause = "Unpause";
     }

     // Update is called once per frame
     void Update()
     {
     }

     public void PauseGame()
     {
           // STATE : UNPAUSED
          // if the game is paused unpause time and audio and change text
          if (Time.timeScale == 0)
          {
               // set the time to 1
               Time.timeScale = 1;
            // change the text box to indicate how to pause
               TextBox1.text = pause;
            // turn off the audio listener 
               AudioListener.pause = false;
          }
          // STATE : PAUSE
          // if the game is playing pause time and audio and change text
          else if (Time.timeScale == 1)
          {
               // set time to 0
               Time.timeScale = 0;
            // update text box to indicate how to unpause
               TextBox1.text = unpause;
            // turn on the audio listener
               AudioListener.pause = true;
          }
     }// end
}