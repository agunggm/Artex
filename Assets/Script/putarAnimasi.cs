using UnityEngine;
using System.Collections;

public class putarAnimasi : MonoBehaviour {

	public GameObject tombol;
	public Animator ani;
	
	
	void Start () 
	{
		ani.enabled = false;
	}
	
	
	public void Press() 
		
	{
		if (!ani.enabled) {
			ani.enabled = true;
		}
		else
		{
			ani.enabled = false;
		}
	}
}
