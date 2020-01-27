using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Environment : MonoBehaviour
{
	public Text time;
	public Text weather;
	public bool isRaining = false;

	private void Start()
	{
		time.text = "12:00 PM";
		weather.text = "Not Raining";
	}

	public void Morning()
	{
		time.text = "9:00 AM";
	}
	public void Noon()
	{
		time.text = "12:00 PM";
	}
	public void Night()
	{
		time.text = "10:00 PM";
	}
	public void ChangeWeather()
	{
		if(isRaining == false)
		{
			isRaining = true;
			weather.text = "Raining";
		}
		else
		{
			isRaining = false;
			weather.text = "Not Raining";
		}
	}
	public void Reload()
	{
		SceneManager.LoadScene("Spawner");
	}
}
