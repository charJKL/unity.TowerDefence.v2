using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public void Instantiate(Vector3 position, GameObject target)
	{
		Instantiate(gameObject, position, Quaternion.identity);
	}
}
