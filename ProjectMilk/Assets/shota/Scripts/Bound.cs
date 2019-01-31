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
            Vector2 refrectVec = Vector2.Reflect(ob.GetComponent<PlayerController_Jin>().GetVec(), col.contacts[0].normal);

            col.gameObject.GetComponent<PlayerController_Jin>().SetVec(refrectVec);

//<<<<<<< HEAD:ProjectMilk/Assets/shota/Scripts/Bound.cs
//            col.gameObject.GetComponent<PLCon_shota>().SetVec(refrectVec);
//            col.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
//            col.gameObject.GetComponent<Rigidbody2D>().AddForce(refrectVec * col.gameObject.GetComponent<PLCon_shota>().plspd);
//=======
//            Debug.Log(refrectVec);
//>>>>>>> origin/master:ProjectMilk/Assets/shota/Bound.cs
        }
    }
}
