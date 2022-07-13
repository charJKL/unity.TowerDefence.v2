using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPath : MonoBehaviour
{
	[SerializeField] private float speed = 3f;
	
	void Update()
	{
		transform.position += transform.forward * speed * Time.deltaTime;
	}
}
