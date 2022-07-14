using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	[SerializeField] private float max = 100f;
	[SerializeField] private float current;
	
	public Action<float> HealthUpdated;
	public float Current { get => current; }
	
	private void Start()
	{
		current = max;
	}

	public void Damage(float damage)
	{
		current -= damage;
		HealthUpdated?.Invoke(current);
	}
}
