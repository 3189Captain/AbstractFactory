using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : IAnimal
{
	public void Voice()
	{
		Debug.Log("Cat: Meow!");
	}
}
