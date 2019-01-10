using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate: MonoBehaviour
{
	public void Left()
	{
		transform.Rotate( 15, 0, 0 );
	}
	public void Right()
	{
		transform.Rotate( -15, 0, 0 );
	}
}
