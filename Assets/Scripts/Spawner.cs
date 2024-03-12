using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject pinPrefab;

//	public AudioClip soundClip;   // 

	private AudioSource sources; // ADDED                      
    
    // Start is called before the first frame update
    void Start() //
    {
        sources = GetComponent<AudioSource>(); //ADDED  
	//  sources = gameObject.AddComponent<AudioSource>();   //
	//  sources.clip = soundClip;   //
    } 

	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			SpawnPin();
			Debug.Log("Playing sound");
			sources.Play();
			Debug.Log("Sound played!");
		}
	}

	void SpawnPin ()
	{
		Instantiate(pinPrefab, transform.position, transform.rotation);
	
	}

}
