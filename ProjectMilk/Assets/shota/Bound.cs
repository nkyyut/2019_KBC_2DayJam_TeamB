using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Vector2 refrectVec = Vector2.Reflect(col.gameObject.GetComponent<PlayerController_Jin>().GetVec(), col.contacts[0].normal);

            col.gameObject.GetComponent<PlayerController_Jin>().SetVec(refrectVec);
        }
    }
}
