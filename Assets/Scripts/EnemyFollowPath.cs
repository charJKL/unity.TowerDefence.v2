using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class EnemyFollowPath : MonoBehaviour
{
	[SerializeField] private float speed = 3f;
	[SerializeField] private PathCreator path;
	
	private float distance;
	
	private void Start()
	{
		distance = 0;
	}
	
	private void Update()
	{
		if(path == null) return;
		distance += speed * Time.deltaTime;
	
		transform.position = path.path.GetPointAtDistance(distance, EndOfPathInstruction.Stop);
		transform.rotation = path.path.GetRotationAtDistance(distance, EndOfPathInstruction.Stop);
	}
}
