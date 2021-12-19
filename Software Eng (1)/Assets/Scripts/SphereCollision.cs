/*
 * This script destroys the falling objects (spheres + images) 
 * after they pass the catcher. This is so their existance does
 * not imapct the game preformance
 * 
 * @author Jacob White (A00435401)
 * @author Kyle Colman-Sadd (A00435483)
 */

// import
using UnityEngine;

// default unity class
public class SphereCollision : MonoBehaviour
{
    // when an object collides with the object this script is attached to
     private void OnCollisionEnter(Collision collision)
     {
        // destroy object that collided
          Destroy(collision.gameObject);
     }

}
// end