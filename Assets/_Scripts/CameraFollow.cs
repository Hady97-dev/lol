using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Transform player;       


	public Vector3 CameraOffset;         //Private variable to store the offset distance between the player and camera

	[Range(0.01f, 1f)]
	public float smoothness = 0.5f;     // two  optional lines

	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		//Calculate and store the offset value by getting the distance between the player's position and camera's position.
		CameraOffset = transform.position - player.transform.position;
	}

	// LateUpdate is called after Update each frame, //after player moves for example 
	void LateUpdate () 
	{
		 
		Vector3 newPos = player.position + CameraOffset;
		transform.position = Vector3.Slerp(transform.position, newPos, smoothness);
	}
}