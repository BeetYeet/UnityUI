using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonToggle : MonoBehaviour {

	public List<Button> buttons;

	public void OnToggle( bool state )
	{
		buttons.ForEach( ( x ) => { x.interactable = state; } );
	}
}
