/*
 * This script plays the audio for the corrct items in the Mi'kmaq language
 * it also updates variables depending on the game state
 * 
 * @author Jacob White (A00435401)
 */

//import
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// unity default class
public class audio : MonoBehaviour
{
    // variables
    // variable for the objects rigidbody
    private Rigidbody c; // define c
    // variables for the audio sources
    public AudioClip audioC;
    public AudioClip audioA;
    public AudioClip audioB;

    AudioSource aaudio;
    Collider col;

    // Start is called before the first frame update
    void Start()
    {
        aaudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // when a trigger enters the object this script is attached to
    private void OnTriggerExit(Collider other)
    {
        // if the trigger has the correct carrot tag
        if (other.tag == "CorrectCarrot")
        {
            // play the audio for carrot in Mi'kmaq
            aaudio.PlayOneShot(audioC);
        }
        // if the trigger has the correct apple tag
        if (other.tag == "CorrectApple")
        {
            //play the audio for apple in Mi'kmaq
            aaudio.PlayOneShot(audioA);
        }
        // if the trigger has the correct banana tag
        if (other.tag == "CorrectBanana")
        {
            //play the audio for banana in Mi'kmaq
            aaudio.PlayOneShot(audioB);
        }
        // if the trigger has the endgame tag
        if (other.tag == "endGame")
        {
            // check the user caught all 3 correct images
            if (CatchImage.numCorrect == 3 && CatchImage.banana == true && CatchImage.carrot == true && CatchImage.apple == true)
            {
                // update the end message
                CatchImage.fGameState = "Great job! Task completed! " +
                "\n You're all rested after a nice break, " +
                "\n and you're ready to get back to work";
                // reset for if the user plays again
                CatchImage.apple = false;
                CatchImage.banana = false;
                CatchImage.carrot = false;
            }
            else
            {
                // reset for if the player wants to play again
                CatchImage.apple = false;
                CatchImage.banana = false;
                CatchImage.carrot = false;

                //update end message
                CatchImage.fGameState = "You got " + CatchImage.numCorrect + " out of three correct!" +
                    "\n You're not quite a master yet, but you soon will be!" +
                    "\n Why don't you try that again :)?";
                CatchImage.numCorrect = 0;

            }
            // load end game scene
            SceneManager.LoadScene("afterCatchMini", LoadSceneMode.Single);
        }
    }
}// end

