using UnityEngine;
using System.Collections;

public class SS : MonoBehaviour {

	[SerializeField]
	public GameObject blink;
	public void tangkapLayar(){
		StartCoroutine("Screenshot");
	}
	IEnumerator Screenshot(){
		string waktu = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string namaFile = "SS-" + waktu + ".png";
		string simpan = namaFile;
		Application.CaptureScreenshot (simpan);
		yield return new WaitForEndOfFrame ();
		Instantiate (blink, new Vector2 (0f, 0f), Quaternion.identity);
	}
}
