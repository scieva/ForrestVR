using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndURLLoader : MonoBehaviour
{
    public void SceneLoad(string sceneName)
	{
		
	}


	public void LoadURL(string url)
	{
		Application.OpenURL(url);
	}
}

