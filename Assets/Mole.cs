using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{

	public float visibleHeight = 0.2f;
	public float hiddenHeight = -0.3f;
	public float speed = 4f;
	public float dissapearDuration = 0.5f;

	private Vector3 targetPosition;
	private float dissapearTimer = 0f;

	// Use this for initialization
	void Awake ()
	{

		// Use transform.localposition instead of transform.position as the Mole has a parent transform. 
		// So this is relative to the parent transform. transform.position is the transform in the worldspace

		targetPosition = new Vector3 (
			transform.localPosition.x,      
			hiddenHeight, 
			transform.localPosition.z);

		transform.localPosition = targetPosition;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		dissapearTimer -= Time.deltaTime;
		if (dissapearTimer <= 0f) {
			Hide ();
		}

		transform.localPosition = Vector3.Lerp (transform.localPosition, targetPosition, Time.deltaTime * speed);
	}


	public void Rise ()
	{

		targetPosition = new Vector3 (
			transform.localPosition.x,      
			visibleHeight, 
			transform.localPosition.z);

		dissapearTimer = dissapearDuration;

	}



	public void Hide ()
	{

		targetPosition = new Vector3 (
			transform.localPosition.x,      
			hiddenHeight, 
			transform.localPosition.z);

	}

	public void OnHit ()
	{
		Hide ();
	}
}
