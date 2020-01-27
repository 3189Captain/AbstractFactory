using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : IHuman
{
	public void Speak()
	{
		Debug.Log("STOP! YOU'VE VIOLATED THE LAW");
	}
}
