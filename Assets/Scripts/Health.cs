using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // [SerializeField] bool isPlayer;
    public static int health = 3;
    // [SerializeField] int damage = 1;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    // [SerializeField] ParticleSystem hitEffect;

    // [SerializeField] bool applyCameraShake;
    
    // CameraShake cameraShake;

    // AudioPlayer audioPlayer;
    // ScoreKeeper scoreKeeper;
    // LevelManager levelManager;
    
    void Awake() 
    {
        // cameraShake = Camera.main.GetComponent<CameraShake>();   
        // audioPlayer = FindObjectOfType<AudioPlayer>();
        // scoreKeeper = FindObjectOfType<ScoreKeeper>();
        // levelManager = FindObjectOfType<LevelManager>();
        health = 3;
    }

    void Update() 
    {
        foreach (Image img in hearts)
        {
            img.sprite = emptyHeart;
        }

        for (int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullHeart;
        }
    }

    // void OnCollisionEnter2D(Collider2D collison) 
    // {
    //         TakeDamage(GetDamage());
    //         // PlayHitEffect();
    //         // audioPlayer.PlayDamageClip();
    //         // ShakeCamera();
    // }

    // int GetDamage()
    // {
    //     return damage;
    // }

    // // int GetHealth()
    // // {
    // //     return health;
    // // }

    // void TakeDamage(int damage)
    // {
    //     health -= damage;

    //     if(health <= 0)
    //     {
    //         Die();
    //     }
    // }

    

    // void Die()
    // {
        
    //     levelManager.LoadGameOver();
    //     Destroy(gameObject);
            
    // }

    // void PlayHitEffect()
    // {
    //     if (hitEffect != null)
    //     {
    //         ParticleSystem instance = Instantiate(hitEffect, transform.position, Quaternion.identity);
    //         Destroy(instance.gameObject, instance.main.duration + instance.main.startLifetime.constantMax);
    //     }
    // }

    // void ShakeCamera()
    // {
    //     if(cameraShake != null && applyCameraShake)
    //     {
    //         cameraShake.Play();
    //     }
    // }

}
