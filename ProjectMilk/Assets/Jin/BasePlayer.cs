using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour {

//-----------------変数---------------------//
    protected Rigidbody2D rigid2D;

    //爆発力
    protected float ExplosionPower;
    //プレイヤーのスピード
    protected float PlayerSpeed;
    //プレイヤーのベクトル
    protected float PlayerVectorX;
    protected float PlayerVectorY;
    protected Vector2 PlayerVector;

//-----------------関数---------------------//
    public float GetExplosionPower(){return ExplosionPower;}
    public float GetPlayerSpeed(){return PlayerSpeed;}
    public float GetPlayerVectorX(){return PlayerVectorX;}
    public float GetPlayerVectorY(){return PlayerVectorY;}
    public Vector2 GetPlayerVector(){return PlayerVector;}

    public void SetExplosionPower(float explosion){ExplosionPower = explosion;}
    public void SetPlayerSpeed(float speed){PlayerSpeed = speed;}
    public void SetPlayerVector(Vector2 vec){PlayerVector = vec;}


	void Start () {
		
	}
	
	void Update () {
		
	}
}
