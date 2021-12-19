/*
 * This script updates the game state
 * 
 * @author Jacob White (A00435401)
 */

//import
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// default unity class
public class gameState : MonoBehaviour { 

    //variables
     private UnityEngine.UI.Text TextBox; // textbox
     public int a; // int variable

    // Start is called before the first frame update
    void Start()
    {
        // find the textbox that needs to be updated
        TextBox = GameObject.Find("state").GetComponent<UnityEngine.UI.Text>();
        // set the textbox text
        string text = TextBox.text;
        a = int.Parse(text);
    }

    // Update is called once per frame
    void Update()
    {
        // update the textbox text
        TextBox.text = a.ToString(CatchImage.fGameState);
    }
} // end
