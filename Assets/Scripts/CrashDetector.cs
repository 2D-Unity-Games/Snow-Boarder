using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
	[SerializeField] float loadDelay = 1;
	
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Ground")
		{
			Invoke(nameof(ReloadLevel), loadDelay);
		}
	}
	
	private void ReloadLevel()
	{
		SceneManager.LoadScene(0);
	}
}
