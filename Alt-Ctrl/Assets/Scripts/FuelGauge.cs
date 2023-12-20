using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelGauge : MonoBehaviour
{
    public Image fuelGauge;
    public float fuelTotal = 100;
    private bool isClicking;
    public float maxTime = 1f;
    private float timeLeft;



    private void Awake()
    {
        timeLeft = maxTime;

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            StartCoroutine(Check());
        }
        
    }

    IEnumerator Check()
    {
        timeLeft -= Time.deltaTime;
        fuelGauge.fillAmount = timeLeft / maxTime;
        yield return new WaitForSeconds(0.5f);
    }
}
