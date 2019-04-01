using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class Player : MonoBehaviour {

    public float speed = 20;
    private bool dead = false;
    public GameObject myo = null;
    private Quaternion _antiYaw = Quaternion.identity;
    void Move(){

        // float moveHorizontal = Input.GetAxis("Horizontal");

        // GetComponent<Rigidbody2D>().velocity = new Vector2(moveHorizontal, 0) * speed;

        ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo>();
        if (dead == false){ 
            if (thalmicMyo.pose == Pose.WaveOut){

               transform.position += Vector3.right * speed * Time.deltaTime;
     
               ExtendUnlockAndNotifyUserAction(thalmicMyo);
            }
        }
 }

void ExtendUnlockAndNotifyUserAction(ThalmicMyo myo){
        ThalmicHub hub = ThalmicHub.instance;

        if (hub.lockingPolicy == LockingPolicy.Standard){
            myo.Unlock(UnlockType.Timed);
        }

        myo.NotifyUserAction();
}

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();

        
    }
}
