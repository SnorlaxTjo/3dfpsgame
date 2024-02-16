using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotater : MonoBehaviour
{
    [SerializeField] float timeForFullRotation;
    [SerializeField] GameObject cameraObject;

    float newRotation;

    private void Update()
    {
        newRotation += (Time.deltaTime / timeForFullRotation) * 360;
        if (newRotation > 360)
        {
            newRotation -= 360;
        }

        cameraObject.transform.rotation = Quaternion.Euler(cameraObject.transform.rotation.x, newRotation, cameraObject.transform.rotation.z);
    }
}
