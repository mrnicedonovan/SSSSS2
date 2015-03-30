using UnityEngine;
using System.Collections;

public class RRRRETRY : MonoBehaviour {
	void OnGUI()
	{
		if (GUI.Button(new Rect(400, 250, 100,150), "Retry"))
		{
			Application.LoadLevel("_Scene01");	
		}
	}
}
