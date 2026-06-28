using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 1, 6);
    public float liftCameraOffset = 0.75f;
    public float liftCameraSpeed;

    private bool liftCamera = false;
    private float leftToLift;

    private void Start()
    {
        leftToLift = liftCameraOffset;
        liftCameraSpeed = 0.015f;
    }

    void Update()
    {
        if (liftCamera == true && leftToLift > 0)
        {
            offset.y += liftCameraSpeed;
            leftToLift -= liftCameraSpeed;
            liftCameraSpeed *= 0.975f;
        }

        transform.position = player.position + offset;
    }

    public void LiftCamera()
    {
        liftCamera = true;
    }
}
