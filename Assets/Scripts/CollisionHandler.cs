using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Finish" && this.tag == "Player")
        {
            Debug.Log("Player Wins");
            //Load next level or send to level select
        }
        else if (other.gameObject.tag == "Spikes" && this.tag == "Player")
        {
            //remove collisionhandler from this gameobject and/or change tag to corpse
            Debug.Log("Player dies");
        }
    }
}
