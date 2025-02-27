using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_dead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bomb_enemy"))
        {
            Destroy(this.gameObject);
        }

        if(collision.gameObject.CompareTag("Power_up"))
        {
            Destroy(collision.gameObject);
            score_manager.instance.addPoints();

        }
    }
}
