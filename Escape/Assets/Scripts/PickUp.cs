using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    
	// Use this for initialization
	public void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            other.gameObject.GetComponent<PlayerLightControls>().AmpLight();

            DestroySelf();

        }
    }

    void DestroySelf() {
        gameObject.SetActive(false);
    }
}
