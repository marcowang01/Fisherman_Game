using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisherman : MonoBehaviour
{
    //[SerializeField] float horizontalSpeed = 10f;
    // [SerializeField] float verticalSpeed = 10f;
    [SerializeField] float steerSpeed = 10f;
    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        // float verticalAmount = Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime;
        // float horizontalAmount = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        // transform.Translate(0, verticalAmount, 0);
        // transform.Translate(horizontalAmount, 0, 0);
        float steerAmount = Input.GetAxis("Vertical") * steerSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
    }
}
