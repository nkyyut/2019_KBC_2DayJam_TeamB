using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SE : MonoBehaviour {

    [SerializeField] GameObject[] SE; // ドレミ壁爆
    PlayerController_Jin pl;

    private void Awake()
    {
        pl = gameObject.GetComponent<PlayerController_Jin>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Instantiate(SE[3]);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            if (pl.GetExplosionPower() <= 1.0f)
            {
                Instantiate(SE[0]);
            }
            else if (pl.GetExplosionPower() <= 1.5f)
            {
                Instantiate(SE[1]);
            }
            else if (pl.GetExplosionPower() > 1.5f)
            {
                Instantiate(SE[2]);
            }
        }
        if(collision.tag == "Enemy")
        {
            Instantiate(SE[4]);
        }
    }

}
