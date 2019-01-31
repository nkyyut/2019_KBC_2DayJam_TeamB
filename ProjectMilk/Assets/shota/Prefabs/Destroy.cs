using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    [SerializeField] float DeathTime = 3.0f;

    private void Update()
    {
        Invoke("Des", DeathTime);
    }

    private void Des()
    {
        Destroy(this.gameObject);
    }
}
