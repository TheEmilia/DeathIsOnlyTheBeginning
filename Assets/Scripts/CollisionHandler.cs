using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    SpawningMechanism spawningMechanism;
    MovementManager movementManager;
    LevelManager levelManager;

    private void Start() {
        spawningMechanism = FindObjectOfType<SpawningMechanism>();
        movementManager = FindObjectOfType<MovementManager>();
        levelManager = FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Finish" && this.tag == "Player")
        {
            Debug.Log("Player Wins");
            //Load next level or send to level select
            levelManager.HandleFinish();
        }
        else if (other.gameObject.tag == "Spikes" && this.tag == "Player")
        {
            //remove collisionhandler from this gameobject and/or change tag to corpse
            Debug.Log("Player dies");
            this.tag = "Corpse";
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
            this.gameObject.GetComponent<MovementManager>().KillPlayer();
            spawningMechanism.SpawnNewPlayer();
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(this.tag == "Player")
        {
            movementManager.SetCanJump(true);
        }
    }
}
