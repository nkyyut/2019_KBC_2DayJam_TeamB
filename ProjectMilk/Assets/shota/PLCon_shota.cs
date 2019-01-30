using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLCon_shota : BasePlayer
{

    [SerializeField] Vector2 myVec;

    void Start()
    {
        base.PlayerSpeed = 200.0f;
        base.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(myVec * Time.deltaTime, 0);

        /* 進行方向を赤棒で示す（Sceneタブのみで目視可能） */
        Debug.DrawLine(gameObject.transform.position, gameObject.transform.position + new Vector3(myVec.x, myVec.y, 0),Color.red);
    }

    public void SetVec(Vector2 v)
    {
        myVec = v;
    }

    public Vector2 GetVec()
    {
        return myVec;
    }
}
