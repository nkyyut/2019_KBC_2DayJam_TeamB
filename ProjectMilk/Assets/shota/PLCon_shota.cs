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

    private void FixedUpdate()
    {
        
    }

    void Update()
    {
        transform.Translate(myVec * Time.deltaTime, 0);
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
