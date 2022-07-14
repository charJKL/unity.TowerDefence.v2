using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiHealthBar : MonoBehaviour
{
	[SerializeField] private Slider slider;
	[SerializeField] private Image fill;
	[SerializeField] private Gradient gradient;
	
	public void Range(float min, float max)
	{
		slider.minValue = min;
		slider.maxValue = max;
	}
	
	public void Set(float value)
	{
		slider.value = value;
		fill.color = gradient.Evaluate(slider.normalizedValue);
	}
}
