using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;

    [Range(0, 1)]
    public float t;

    private Vector3 initPos;

    private void MoveToTarget()
    {
        Vector3 dir = target.position - transform.position;

        transform.position += (Vector3)BasicMath.Normalize(dir) * speed * Time.deltaTime;
    }

    private void MoveToTargetLerp()
    {
        transform.position = BasicMath.Vector2Lerp(initPos, target.position, t);
    }

    private void Awake()
    {
        initPos = transform.position;
    }

    private void Dot()
    {
        Vector3 dir = target.position - transform.position;

        Vector3 normalizedA = BasicMath.Normalize(transform.up);
        Vector3 normalizedB = BasicMath.Normalize(dir);

        Debug.Log(BasicMath.Dot(normalizedA, normalizedB));
    }

    private void Angle()
    {
        Vector3 dir = target.position - transform.position;

        Debug.Log(BasicMath.AngleDeg(transform.up, dir));
    }

    private void Update()
    {
        //MoveToTargetLerp();
        //MoveToTarget();
        //Dot();
        Angle();
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + transform.up * 2);
        Vector3 dir = target.position - transform.position;
        Gizmos.DrawLine(transform.position, transform.position + dir);
    }
}
