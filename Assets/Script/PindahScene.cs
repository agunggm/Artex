using UnityEngine;
using System.Collections;

public class PindahScene : MonoBehaviour {

	public void pindahScene(string nama){
		Application.LoadLevel (nama);
	}
}
