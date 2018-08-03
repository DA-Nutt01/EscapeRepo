using System.Collections;
using UnityEngine;

public class LightAdjuster : MonoBehaviour {

    public new Light light;

	// Use this for initialization
	void Start () {
        light = GetComponentInChildren<Light>();
	}
	
    public void ampLight() {
        light.range += 1f;
        light.intensity += 1f;
    }
}
