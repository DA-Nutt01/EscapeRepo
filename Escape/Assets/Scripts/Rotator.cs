using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime * 2);
    }
}
