using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSmooth : MonoBehaviour
{
    
    public Transform target;
    public Vector3 offset;
    public float smoothAmount;

    private void Update() 
    {
        Follow();
    }

    private void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothAmount * Time.fixedDeltaTime);
        transform.position = smoothPosition;

    }

}
