﻿using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class TimerToggle : MonoBehaviour {

    [SerializeField]
    private float startTime;

    [SerializeField]
    private float interval;

    [SerializeField]
    private UnityEvent toCall;

    // Use this for initialization
    void Start () {
        InvokeRepeating("CallEvent", startTime, interval);
	}

    void CallEvent()
    {
        toCall.Invoke();
    }
}
