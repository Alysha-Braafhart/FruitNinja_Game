using System.Collections.Generic;
using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEditor.Rendering.LookDev;

public class Swipe : MonoBehaviour
{
	private Vector3 mousePosition;
	private Vector3 defaultPosition;
	public float moveSpeed = 0.1f;

	// Use this for initialization
	void Start () {
		defaultPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
			mousePosition.z = transform.position.z;
			transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
		}
		else
		{
			transform.position = Vector2.Lerp(transform.position, defaultPosition, moveSpeed);
		}
	}
}
