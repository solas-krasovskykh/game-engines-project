using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 1, 6);
    public float liftCameraOffset = 0.5f;

    private bool liftCamera = false;
    private float leftToLift;

    private void Start()
    {
        leftToLift = liftCameraOffset;
    }

    void Update()
    {
        if (liftCamera == true && leftToLift > 0)
        {
            offset.y += 0.002f;
            leftToLift -= 0.002f;
        }

        transform.position = player.position + offset;
    }

    public void LiftCamera()
    {
        liftCamera = true;
    }
}
