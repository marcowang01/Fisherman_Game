using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    LevelManager levelManager;
    
    void Awake() 
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Die();
            }
        }
    }

    void Die()
    {
        
        levelManager.LoadGameOver();
        Destroy(gameObject);
            
    }

    // IEnumerator GetHurt()
    // {
    //     Physics2D.IgnoreLayerCollision(3, 6);
    //     yield return new WaitForSeconds(3);
    //     Physics2D.IgnoreLayerCollision(3, 6, false);
    // }

}
