using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningMechanism : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    Transform spawnLocation;
    public void SpawnNewPlayer()
    {
        spawnLocation = this.gameObject.transform;
        Instantiate(playerPrefab,spawnLocation);
    }
}
