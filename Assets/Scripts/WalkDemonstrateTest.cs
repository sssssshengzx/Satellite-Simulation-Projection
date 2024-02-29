using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkDemonstrateTest : MonoBehaviour
{
    public float speed;
    public Transform[] targets;

    private int index = 0;

    void Update()
    {
        if (index == targets.Length) index = 0;
        transform.position = Vector3.MoveTowards(transform.position, targets[index].position, Time.deltaTime * speed);
        transform.LookAt(targets[index].position);

        if (Vector3.Distance(transform.position, targets[index].position) <= .1f)
        {
            index++;
        }

    }
}

