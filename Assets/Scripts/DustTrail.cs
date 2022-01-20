using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
	[SerializeField] ParticleSystem dustVFX;
	
	private void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Ground")
		{
			dustVFX.Play();
		}
	}
	
	private void OnCollisionExit2D(Collision2D other) {
		if(other.gameObject.tag == "Ground")
		{
			dustVFX.Stop();
		}
	}
}
