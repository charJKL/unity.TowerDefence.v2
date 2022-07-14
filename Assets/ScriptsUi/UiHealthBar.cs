using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiHealthBar : MonoBehaviour
{
	[SerializeField] private Image bar;
	[SerializeField] private Gradient gradient;
	
	private float min;
	private float max;

	public void Range(float min, float max)
	{
		this.min = min;
		this.max = max;
	}
	
	public void Set(float value)
	{
		float normalizedValue = value / max;
		bar.fillAmount = normalizedValue;
		bar.color = gradient.Evaluate(normalizedValue);
	}
}
