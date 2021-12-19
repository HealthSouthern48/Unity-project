/*
 * This script plays the audio for the corrct items in the Mi'kmaq language
 * it also updates variables depending on the game state
 * 
 * @author Jacob White (A00435401)
 * @author Isaiah Jarvis (A00439675)
 */

// import
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// default unity class
public class CatchImage : MonoBehaviour
{
    // variables
     private Rigidbody c; // object colliding
     private UnityEngine.UI.Text TextBox; // textbox
     AudioSource audio; // Gets both audio components
     public AudioClip audioWin; // audio for correct image
     public AudioClip audioLose; // audio for incorrect image
     public int a;

    // game state
     public static string fGameState = "Great job!" +
        "\n You're really becoming a master at this!" +
        "\n You got " + CatchImage.numCorrect + " out of 3 correct";

    // more variables
     public static int numCorrect = 0;
     public static bool carrot = false;
     public static bool apple = false;
     public static bool banana = false;

    // Start is called before the first frame update
    void Start()
     {
          // get the rigidbody component
          c = transform.GetComponent<Rigidbody>();

          // get the audio componen(s)
          audio = transform.GetComponent<AudioSource>();
          
          // find the score and update it
          TextBox = GameObject.Find("ScoreText").GetComponent<UnityEngine.UI.Text>();
          string text = TextBox.text;
          a = int.Parse(text);
     }

     // Update is called once per frame
     void Update()
     {
     }
     // when something collides with the object this script is attached to
     void OnCollisionEnter(Collision collision)
     {
          // check if the GameObject has a certain tag
          if (collision.gameObject.tag == "CorrectCarrot" || collision.gameObject.tag == "CorrectApple" || collision.gameObject.tag == "CorrectBanana")
          {
               // play correct item sound
               audio.PlayOneShot(audioWin);

               // increase score
               ++a;
               // set new number
               if (a >= 0)
               {
                    TextBox.text = a.ToString("00");
               }
               // if the collision object has the correct carrot tag
            if (collision.other.tag == "CorrectCarrot")
            {
                // update the number of correct images caught
                CatchImage.numCorrect += 1;
                // update that the user has caught the correct carrot
                CatchImage.carrot = true;
            }
            // if the collision object has the correct apple tag
            if (collision.other.tag == "CorrectApple")
            {
                // update the number of correct images caught
                CatchImage.numCorrect += 1;
                // update that the user has caught the correct apple
                CatchImage.apple = true;
            }
            // if the collision object has the correct banana tag
            if (collision.other.tag == "CorrectBanana")
            {
                // update the number of correct images caught
                CatchImage.numCorrect += 1;
                // update that the user has caught the correct banana
                CatchImage.banana = true;
            }
        }
          // if it's the incorrect image
          if (collision.gameObject.tag == "Incorrect")
          {
               // play wrong item sound
               audio.PlayOneShot(audioLose);

               // if a is greater than 0 decrease score by 1
               if (a > 0)
               {
                    --a;
                    TextBox.text = a.ToString("00");
               }
          }
     }
    // destroy the object after it is caught (stays in the collision zone)
     private void OnCollisionStay(Collision collision)
     {
          Destroy(collision.gameObject);
     }
     
}// end