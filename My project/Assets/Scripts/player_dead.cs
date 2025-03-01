using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class player_dead : MonoBehaviour
{
    public ParticleSystem bombCollisionParticleSystem;
    public ParticleSystem powerUpCollisionParticleSystem;
    //public bool once = true;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bomb_enemy"))
        {
            ParticleSystem particle = Instantiate(bombCollisionParticleSystem, transform.position, Quaternion.identity);
            particle.Play();
            Destroy(particle.gameObject, particle.main.duration);
            Destroy(this.gameObject);
            score_manager.instance.OnRobotDestroyed();
        }

        if (collision.gameObject.CompareTag("Power_up"))
        {
            ParticleSystem particle = Instantiate(powerUpCollisionParticleSystem, transform.position, Quaternion.identity);
            particle.Play();
            Destroy(particle.gameObject, particle.main.duration);
            Destroy(collision.gameObject);
            score_manager.instance.AddPoints();
        }

    }

}
