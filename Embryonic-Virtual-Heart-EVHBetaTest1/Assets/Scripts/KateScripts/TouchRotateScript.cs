using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotateScript : MonoBehaviour
{
    float rotationspeed = 20;
    private void OnMouseDrag()
    {
        float rotx = Input.GetAxis("Mouse X") * rotationspeed * Mathf.Deg2Rad;
        float roty = Input.GetAxis("Mouse Y") * rotationspeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotx);
        transform.RotateAround(Vector3.right, -roty);
    }
}
