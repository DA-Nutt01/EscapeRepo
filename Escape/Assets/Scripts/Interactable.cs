using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius;

    bool isFocus = false;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public virtual void Interact () 
    {
        Debug.Log("Interacting " + transform.name);
    }

    void Update()
    {
        if (isFocus)
        {
                //CHECK FOR PLAYER INTERACTION INPUT
                if (Input.GetMouseButtonDown(0))
                {
                    //INTERACT
                    Interact();
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
