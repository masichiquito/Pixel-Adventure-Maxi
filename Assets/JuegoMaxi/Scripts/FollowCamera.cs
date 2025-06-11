using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float CameraSpeed = 1.0f;
    private Vector3 offsetDistance;

    // Start is called before the first frame update
    void Start()
    {
        offsetDistance = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Debug.Log("Player no found");
            return;
        }

        transform.position = Vector3.Lerp(transform.position, target.position + offsetDistance, CameraSpeed * Time.deltaTime);
    }
}