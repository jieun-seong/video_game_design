using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCameraScript : MonoBehaviour
{
    public Transform camera;

    // billboard script
    void LateUpdate()
    {
        transform.LookAt(transform.position + camera.forward);
    }
}
