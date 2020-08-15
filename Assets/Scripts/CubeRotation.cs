using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    private void FixedUpdate()
    {
        var angle = transform.rotation;

        transform.rotation *= Quaternion.AngleAxis(5, Vector3.up) * Quaternion.AngleAxis(5, Vector3.right);
        
    }
}
