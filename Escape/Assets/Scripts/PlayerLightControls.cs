using System.Collections;
using UnityEngine;

public class PlayerLightControls : MonoBehaviour {

    public new Light light;

	void Start () {
        light = GetComponentInChildren<Light>();
	}

    // Increases the range and intensity of light object by set amount
    public void AmpLight() {
        GameObject Player = GameObject.Find("Player"); // Finds the Player
        LightPulse lightPulse = Player.GetComponent<LightPulse>(); // Finds the script on the Player responsible for lighting

        lightPulse.peakRange += 1f;
        lightPulse.baseRange += 1f;
        lightPulse.intensityRamp += 0.5f;

        lightPulse.baseIntensity += 1f;
        lightPulse.peakIntensity += 1f;
        lightPulse.rangeRamp += 0.5f;
    }

    // Decreases the range and intensity of light object by set amount
    public void DepleteLight() {
        light.range -= 1f;
        light.intensity -= 1f;
    }
}
