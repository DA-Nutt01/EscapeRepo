using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPulse : MonoBehaviour {

    private new Light light;

    // Range instance vars {
    public float rangeRamp; 
    public float peakRange;
    public float baseRange;
    // }

    // Intensity instance vars {
    public float intensityRamp; 
    public float peakIntensity;
    public float baseIntensity;
    // }



	// Use this for initialization
	void Start () {
        light = GetComponentInChildren<Light>();
        baseIntensity = light.intensity;
        baseRange = light.range;
	}
	
	// Update is called once per frame
	void Update () {
        light.range = PingPong(Time.time * rangeRamp, baseRange, peakRange);
        light.intensity = PingPong(Time.time * intensityRamp, baseIntensity, peakIntensity);
	}

    // Edits the Mathf.PingPong method by adding a min value to the parameter list 
    float PingPong(float aValue, float aMin, float aMax)
    {
        return Mathf.PingPong(aValue, aMax - aMin) + aMin;
    }

}
