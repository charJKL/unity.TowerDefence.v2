using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
	[SerializeField] private EnemyHealth health;
	[SerializeField] private UiHealthBar healthBar;

	private void Start()
	{
		healthBar.Range(0, 100);
		healthBar.Set(health.Current);
		health.HealthUpdated += UpdateHealthBar;
	}
	
	private void UpdateHealthBar(float health)
	{
		healthBar.Set(health);
	}
}
