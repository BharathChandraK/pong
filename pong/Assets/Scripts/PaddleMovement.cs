using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    /* public float speed = 10;

     public Transform RP;
     public Transform LP;

     Vector2 RightInput;
     Vector2 LeftInput;

     float verticalExtent;

     private void Start()
     {
         verticalExtent = Camera.main.orthographicSize;
     }

     private void Update()
     {
         Movement();
     }

     void Movement()
     {
         Vector2 rd;
         Vector2 ld;

         RightInput = new Vector2(0, Input.GetAxisRaw("RP")) * speed * Time.deltaTime;
         LeftInput = new Vector2(0, Input.GetAxisRaw("LP")) *speed * Time.deltaTime;

         RP.Translate(RightInput);
         LP.Translate(LeftInput);

         rd = RP.transform.position;
         rd.y = Mathf.Clamp(rd.y, -verticalExtent + RP.localScale.y / 2, verticalExtent- RP.localScale.y / 2);
         RP.position = rd;

         ld = LP.transform.position;
         ld.y = Mathf.Clamp(ld.y, -verticalExtent+LP.localScale.y/2, verticalExtent-LP.localScale.y/2);
         LP.position = ld;
     }*/


    public float speed = 12;

    public Transform RP;
    public Transform LP;

    Vector2 RightInput;
    Vector2 LeftInput;

    float verticalExtent;

    private void Start()
    {
        verticalExtent = Camera.main.orthographicSize;
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector2 rd;
        Vector2 ld;

        RightInput = new Vector2(0, Input.GetAxisRaw("RP")) * speed * Time.deltaTime;
        LeftInput = new Vector2(0, Input.GetAxisRaw("LP")) * speed * Time.deltaTime;

        RP.Translate(RightInput);
        LP.Translate(LeftInput);

        rd = RP.transform.position;
        rd.y = Mathf.Clamp(rd.y, -verticalExtent+RP.localScale.y / 2, verticalExtent-RP.localScale.y / 2);
        RP.position = rd;

        ld = LP.transform.position;
        ld.y = Mathf.Clamp(ld.y, -verticalExtent + LP.localScale.y / 2, verticalExtent - LP.localScale.y / 2);
        LP.position = ld;
    }

}

