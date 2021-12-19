/*
 * This script loads new scenes, and/ or quit the game
 * on the clicking of a button object
 * 
 * @author Jacob White (A00435401)
 */

//import
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // a method to exit the game
    public void exit()
    {
        Application.Quit(); // quit the application
    }
     // a method to load a new scene
    public void load(string name)
    {
        SceneManager.LoadScene(name, LoadSceneMode.Single); // load new scene with given name
    }
}// end
