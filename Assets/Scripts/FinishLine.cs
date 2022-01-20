using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
	[SerializeField] float loadDelay = 1;
	[SerializeField] ParticleSystem finishVFX;
	
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player")
		{
			finishVFX.Play();
			GetComponent<AudioSource>().Play();
			Invoke(nameof(ReloadLevel), loadDelay);
		}
	}
	
	private void ReloadLevel()
	{
		SceneManager.LoadScene(0);
	}
}
