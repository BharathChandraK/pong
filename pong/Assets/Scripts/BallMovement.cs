using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public float speed = 15f;

    public Transform RP;
    public Transform LP;

    float verticalExtent;
    float horizontalExtent;

    Vector2 direction;

    int rs =0;
    int ls = 0;

    public Text rscore;
    public Text lscore;

    private void Start()
    {
        verticalExtent = Camera.main.orthographicSize;
        horizontalExtent = verticalExtent * Camera.main.aspect;
        ballreset();
    }

    private void Update()
    {
        ballmovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballreset();
        }
        
    }

    void ballreset()
    {
        transform.position = Vector2.zero;
        direction = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized*speed*Time.deltaTime;
    }

    void ballmovement()
    {
        transform.Translate(direction);

        ballCollisionWithWalls();
        collosionWithRP();
        collosionWithLP();
        checkscore();


    }

    void ballCollisionWithWalls()
    {
        if(transform.position.y+transform.localScale.x/2>=verticalExtent)
        {
            direction.y *= -1;
        }

        if (transform.position.y - transform.localScale.x/2<=-verticalExtent)
        {
            direction.y *= -1;
        }
    }

    void collosionWithRP()
    {
        if(transform.position.x>=RP.position.x)
        {
            if (transform.position.y > RP.position.y - RP.localScale.y / 2 && transform.position.y < RP.position.y + RP.localScale.y/2)
            {
                direction.x *= -1;
            }
        }
    }

    void collosionWithLP()
    {
        if(transform.position.x<=LP.position.x)
        {
            if (transform.position.y > LP.position.y - LP.localScale.y / 2 && transform.position.y < LP.position.y + LP.localScale.y / 2)
            {
                direction.x *= -1;
            }
        }
    }

    void checkscore()
    {
        if(transform.position.x>horizontalExtent)
        {
            ballreset();
            ls++;
            lscore.text = ls.ToString();
        }

        if (transform.position.x < -horizontalExtent)
        {
            ballreset();
            rs++;
            rscore.text = rs.ToString();
        }

        if (rs>=3)
        {
            
            rscore.text = "YOU WIN";
            transform.position = Vector2.zero;
        }


        if(ls==3)
        {
            rscore.text = "YOU LOOSE";
        }

        if (rs==3)
        {
            lscore.text="YOU LOOSE";
        }
        

        if(ls>=3)
        {
            lscore.text = "YOU WIN";
            transform.position = Vector2.zero;
        }

       
    }
}
