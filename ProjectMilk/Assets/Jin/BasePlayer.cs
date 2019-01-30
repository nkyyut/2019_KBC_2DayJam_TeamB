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

//-----------------関数---------------------//
    public float GetExplosionPower(){return ExplosionPower;}
    public float GetPlayerSpeed(){return PlayerSpeed;}
    public float GetPlayerVectorX(){return PlayerVectorX;}
    public float GetPlayerVectorY(){return PlayerVectorY;}

    public void SetExplosionPower(float explosion){explosion = ExplosionPower;}
    public void SetPlayerSpeed(float speed){speed = PlayerSpeed;}
    public void SetPlayerVector(float X, float Y){X = PlayerVectorX; Y = PlayerVectorY;}


	void Start () {
		
	}
	
	void Update () {
		
	}
}
