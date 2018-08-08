using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;

    public Interactable focus;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);


    }

    void SetFocus (Interactable newFocus)
    {
        focus = newFocus;
        newFocus.OnFocused();
    }

    void RemoveFocus (Interactable oldFocus)
    {
        focus = null;
        oldFocus.OnDefocused();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Interactable")) 
        {
            Interactable interactable = other.GetComponent<Interactable>();
            SetFocus(interactable);
        }
    }

    void OnTriggerExit(Collider other)
    {
        Interactable interactable = other.GetComponent<Interactable>();
        RemoveFocus(interactable);
    }

}
