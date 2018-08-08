using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius;

    bool isFocus = false;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    void Update()
    {
        if (isFocus)
        {
            //CHECK FOR PLAYER INTERACTION INPUT
            if (Input.GetMouseButtonDown(0))
            {
                //INTERACT
                Debug.Log("Interacting " + transform.name);
            }
           
        }
    }

    public void OnFocused () 
    {
        isFocus = true;
    }

    public void OnDefocused () 
    {
        isFocus = false;
    }

  
}
