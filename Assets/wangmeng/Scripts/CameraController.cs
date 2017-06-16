using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization

	public Transform PlayerPos;
	public float speed = 0.1f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		UpdateRotation();
		UpdatePosition();
		
	}
	
	void UpdateRotation()
	{
       Camera.main.transform.RotateAround(PlayerPos.position, Vector3.up, speed );
	}
	void UpdatePosition()
	{
          Vector3 TempPos=transform.position;

		  transform.position=new Vector3(TempPos.x,PlayerPos.position.y,TempPos.z);
	}
}
