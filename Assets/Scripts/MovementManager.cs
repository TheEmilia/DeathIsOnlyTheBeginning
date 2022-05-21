using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField] float playerSpeedModifier = 1f;
    float xInput = 0f;
    float yInput = 0f;

    void Start()
    {
        
    }
    void Update()
    {
        // translate speed update
        xInput = playerSpeedModifier * Input.GetAxis("Horizontal") * Time.deltaTime;
        yInput = playerSpeedModifier * Input.GetAxis("Vertical") * Time.deltaTime;
        // translate action

        transform.Translate(xInput, yInput, 0f);
    }
}
