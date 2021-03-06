﻿using UnityEngine;
using System.Collections;

public class SmoothFollow2D : MonoBehaviour
{

    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public GameObject target;
    public Vector3 offset;
    private Vector3 targetPos;

    [SerializeField]
    bool lookForPlayerTarget;

    // Use this for initialization
    void Start()
    {
        targetPos = transform.position;

        if(lookForPlayerTarget)
        {
            target = GameObject.FindGameObjectWithTag("CameraTarget");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target)
        {
            Vector3 posNoZ = transform.position;
            posNoZ.z = target.transform.position.z;

            Vector3 targetDirection = (target.transform.position - posNoZ);

            interpVelocity = targetDirection.magnitude * 5f;

            targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);

            transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.25f);

        }
    }
}
