using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{

	private Vector3 initialPosition;


	// Use this for initialization
	void Start ()
	{
		initialPosition = transform.position;
	}


	public void Hit (Vector3 targetPosition)
	{
		transform.position = targetPosition;

	}
	// Update is called once per frame
	void Update ()
	{

		transform.position = Vector3.Lerp (transform.position, initialPosition, Time.deltaTime);
		
	}
}
