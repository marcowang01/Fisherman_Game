using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Vector2 screenBounds;
    LevelManager levelManager;

    void Awake() 
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    
        if(transform.position.x < screenBounds.x - 50) 
        {
            Destroy(this.gameObject);
        }
    }

    // void OnCollisionEnter2D(Collision2D collison) 
    // {
    //     Destroy(this.gameObject);
    //     levelManager.LoadGameOver();
    // }
}
