using System.Collections.Generic;
using UnityEngine;

public class AltarInteraction : Interactable {

    public override void Interact()
    {
        base.Interact();

        // Finds the Player
        GameObject Player = GameObject.Find("Player");

        // Finds the script on the Player responsible for lighting
        LightPulse lightPulse = Player.GetComponent<LightPulse>();

        lightPulse.peakRange = 13f; // max pingpong point
        lightPulse.baseRange = 12f; // min ping pong point
        lightPulse.intensityRamp = 2f; // adjust pulse rate to new intensity

        lightPulse.baseIntensity = 3f; // min ping pong point
        lightPulse.peakIntensity = 3.5f; // max ping pong point
        lightPulse.rangeRamp = 2f; // adjust pulse rate to new range
    }
}
