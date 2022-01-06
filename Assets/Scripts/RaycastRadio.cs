using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastRadio : MonoBehaviour
{
    //public GameObject Radio;

    public GameObject TalkRadio;
    
    public Transform raycastOrigin;

    public LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {
        SimpleRaycast();
    }

    private void SimpleRaycast()
    {
        Debug.DrawRay(raycastOrigin.position, transform.forward * .5f, Color.magenta);

        if(Physics.Raycast(raycastOrigin.position,transform.forward,.5f))
        {
            TurnOnRadio();
        }
    }

    private void TurnOnRadio()
    {
        Debug.Log("Radio Active");
        TalkRadio.SetActive(true);
    }

}
