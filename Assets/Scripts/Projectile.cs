using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	[SerializeField] private float speed = 5.0f;
	
	private Transform target;
	
	public void Init(Vector3 position, Enemy target)
	{
		Projectile projectile = Instantiate(gameObject, position, Quaternion.identity).GetComponent<Projectile>();
		projectile.target = target.Body;
	}
	
	private void LateUpdate()
	{
		Vector3 direction = (target.position - transform.position).normalized;
		transform.rotation = Quaternion.LookRotation(direction, transform.up);
		transform.position += direction * speed * Time.deltaTime;
		Debug.DrawLine(target.position, transform.position, Color.green);
	}
}
