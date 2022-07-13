using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerEnemiesInRange : MonoBehaviour
{
	[SerializeField] private List<GameObject> enemies;
		
	private SphereCollider range;
	
	public List<GameObject> Enemies { get => enemies; }

	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag(Tags.ENEMY)) enemies.Add(other.gameObject);
	}
	
	private void OnTriggerExit(Collider other)
	{
		enemies.Remove(other.gameObject);
	}
	
	public bool IsSomeoneInRange()
	{
		return enemies.Count > 0;
	}
}
