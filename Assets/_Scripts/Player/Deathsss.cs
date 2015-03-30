using UnityEngine;
using System.Collections;

public class Deathsss : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PlayerDys ();
	}
	void PlayerDys()
	{
		if(transform.position.y <= -6.6)
		{
			Application.LoadLevel("GameOber");
			
		}
	}
}
