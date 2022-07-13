using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttackProjectile : MonoBehaviour
{
	[SerializeField] private TowerEnemiesInRange enemiesInRange;
	[SerializeField] private GameObject prefabProjectile;
	[SerializeField] private float rate = 0.5f;
	
	private float timeout = 0;
	
	private void Start()
	{
		timeout = 0;
	}
	
	private void Update()
	{
		if(Time.time >= timeout)
		{
			if(enemiesInRange.IsSomeoneInRange())
			{
				Debug.Log("Attack one of the enemy");
				timeout = Time.time + rate;
			}
		}
	}
}
