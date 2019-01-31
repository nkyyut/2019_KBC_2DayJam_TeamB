using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour {

    GameObject ob;

    private void Start()
    {
        ob = GameObject.Find("Player");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log(ob.GetComponent<PlayerController_Jin>().GetVec());
            Vector2 refrectVec = Vector2.Reflect(ob.GetComponent<PlayerController_Jin>().GetVec(), col.contacts[0].normal);

            col.gameObject.GetComponent<PlayerController_Jin>().SetVec(refrectVec);

            Debug.Log(refrectVec);
        }
    }
}
