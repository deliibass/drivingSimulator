using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public GameObject cameraLookFront, cameraLookBack;

    private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 offset1 = new Vector3(0, 5, 8);

    public float cameraControl;
    // Start is called before the first frame update
    void Start()
    {
        cameraLookBack.SetActive(false);
        cameraLookFront.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        cameraControl = Input.GetAxis("Vertical");

        if(Input.GetAxis("Vertical") >= 0)
        {
            cameraLookBack.SetActive(false);
            cameraLookFront.transform.position = player.transform.position + offset;
        }
        else
        {
            cameraLookBack.transform.position = player.transform.position + offset1;
            cameraLookBack.SetActive(true);
        }

        cameraControl = 0;
    }
}
