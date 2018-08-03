using System.Collections;
using UnityEngine;

public class LightAdjuster : MonoBehaviour {

    public new Light light;

	// Use this for initialization
	void Start () {
        light = GetComponentInChildren<Light>();
	}
	
    public void AmpLight() {
        light.range += 1f;
        light.intensity += 1f;
    }

    public void DepleteLight() {
        light.range -= 1f;
        light.intensity -= 1f;
    }
}
