using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConstructionHighlight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField] private new MeshRenderer renderer;
	[SerializeField] private Material hover;
	
	private Material idle;
	
	private void Start()
	{
		idle = renderer.material;
	}
	
	void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
	{
		renderer.material = hover;
	}
	
	void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
	{
		renderer.material = idle;
	}
}
