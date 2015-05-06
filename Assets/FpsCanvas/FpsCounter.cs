using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FpsCounter : MonoBehaviour {
	private const float INTERVAL = 1.0f;
	public Text FpsText;
	private int Frames  = 0;
	private float oldTime = 0;

	// Use this for initialization
	void Start () {
		oldTime = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
		Frames++;
		float ellapsed = Time.realtimeSinceStartup - oldTime;
		if (ellapsed > INTERVAL) {
			float fps  = Frames / ellapsed;
			FpsText.text = "Fps " + fps.ToString("#.00");
			oldTime = Time.realtimeSinceStartup;
			Frames = 0;
		}
	}
}
