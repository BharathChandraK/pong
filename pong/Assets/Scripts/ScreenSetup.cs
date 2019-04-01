using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSetup : MonoBehaviour
{

    public Transform RP;
    public Transform LP;

    float horizontalExtent;

    private void Start()
    {
        horizontalExtent = Camera.main.aspect * Camera.main.orthographicSize;
        RP.position = new Vector3(horizontalExtent-RP.localScale.x/2, 0, 0);
        LP.position = new Vector3(-horizontalExtent+LP.localScale.x/2, 0, 0);

    }
}
