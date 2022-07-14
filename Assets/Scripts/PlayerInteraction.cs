using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
	private Ray ray;
	private RaycastHit hit;
	
	private void OnSelect(InputValue value)
	{
		Vector2 mousePosition = Mouse.current.position.ReadValue();
		GameObject clicked = GetObjectUnderCursor(mousePosition);
		if(clicked)
		{
			Debug.Log($"Mouse was OnSelect {clicked.name}");
		}
	}
	
	private void OnUnselect()
	{
		Debug.Log("Mouse was OnUnselect");
	}
	
	private void OnHover(InputValue value)
	{
		Vector2 mousePosition = value.Get<Vector2>();
		GameObject hover = GetObjectUnderCursor(mousePosition);
		if(hover)
		{
			// Debug.Log($"Mouse hover: {hover.name}");
		}
	}
	
	private GameObject GetObjectUnderCursor(Vector2 position)
	{
		ray = Camera.main.ScreenPointToRay(position);
		if(Physics.Raycast(ray, out hit, float.MaxValue, Layers.INTERACTABLE))
		{
			return hit.collider.gameObject;
		}
		return null;
	}
}
