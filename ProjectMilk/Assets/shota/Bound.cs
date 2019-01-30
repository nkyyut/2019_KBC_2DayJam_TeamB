using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour {

    //GameObject Player;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Vector2 refrectVec = Vector2.Reflect(col.gameObject.GetComponent<PLCon_shota>().GetVec(), col.contacts[0].normal);

            col.gameObject.GetComponent<PLCon_shota>().SetVec(refrectVec);
        }
    }
}
