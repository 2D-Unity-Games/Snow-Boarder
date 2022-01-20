using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
	[SerializeField] float loadDelay = 1;
	[SerializeField] ParticleSystem crashVFX;
	[SerializeField] AudioClip crashSFX;
	
	bool hasCrashed = false;
	
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Ground" && !hasCrashed)
		{
			FindObjectOfType<PlayerController>().DisableControls();
			hasCrashed = true;
			crashVFX.Play();
			GetComponent<AudioSource>().PlayOneShot(crashSFX);
			Invoke(nameof(ReloadLevel), loadDelay);
		}
	}
	
	private void ReloadLevel()
	{
		SceneManager.LoadScene(0);
	}
}
