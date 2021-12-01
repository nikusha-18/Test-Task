using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Character character;
    public Transform DefaultPos;
    public Transform TargetPos;
    public float speed;

    public static bool isGoingToTarget;
    public static bool isGoingBack;

    public int lastClicked;

    void Update()
    {
        if (isGoingToTarget)
        {
            transform.position = Vector3.Lerp(transform.position, TargetPos.position, speed * Time.deltaTime);
        }
        if(isGoingBack)
        {
            transform.position = Vector3.Lerp(transform.position, DefaultPos.position, speed * Time.deltaTime);
        }
    }

    public void Swap()
    {
        isGoingBack = false;
        isGoingToTarget = true;

        lastClicked++;

        if (lastClicked > 1)
        {
            isGoingBack = true;
            isGoingToTarget = false;

            lastClicked = 0;
        }
    }
}
