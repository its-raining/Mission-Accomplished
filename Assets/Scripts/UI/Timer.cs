﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float currentTime;
    private RectTransform RectTF;
    private bool updateLock;

    // Start 
    private void Start()
    {
        RectTF = GetComponent<RectTransform>();
        updateLock = true;
        StartCoroutine(UnlockUpdate());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // update time
        currentTime += Time.fixedDeltaTime;

        // rotate clock pointer
        RectTF.Rotate(0f, 0f, -Time.fixedDeltaTime * Config.MODIFIER_TIMER);

        print(currentTime % 180f);

        // update date
        if (currentTime % Config.TIME_ONEDAY >= -0.1f && currentTime % Config.TIME_ONEDAY <= 0.1f && !updateLock)
        {
            Debug.Log("Go Next Day");
            GameController.GC.GoToNextDay();
            updateLock = true;
            StartCoroutine(UnlockUpdate());
        }
    }

    IEnumerator UnlockUpdate()
    {
        yield return new WaitForSecondsRealtime(Config.TIME_DAY_UPDATE_DELAY);
        updateLock = false;
    }
}
