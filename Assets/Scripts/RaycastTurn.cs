using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTurn : MonoBehaviour
{
    public Transform raycastOrigin;

    public LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {
        SimpleRaycast();
    }

    private void SimpleRaycast()
    {
        Debug.DrawRay(raycastOrigin.position, transform.forward * 1f, Color.magenta);

        if(Physics.Raycast(raycastOrigin.position,transform.forward,1f))
        {
            TurnAround();
        }
    }

    private void TurnAround()
    {
        transform.rotation *= Quaternion.Euler(0, 180f, 0);
    }

}
