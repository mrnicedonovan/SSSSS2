using UnityEngine;
using System.Collections;

public class STAARTTTT : MonoBehaviour {
	void OnGUI()
	{
		if (GUI.Button(new Rect(400, 250, 100,100), "Start Game"))
		{
			Application.LoadLevel("_Scene01");	
		}
	}
}
