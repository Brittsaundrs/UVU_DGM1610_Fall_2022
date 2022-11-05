using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MySO : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // adds or subtracts deltaTime to currentTime
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        // check limit of timer status and whether we're going above/below limit
        if(hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.red;
            // will stop running
            enabled = false;
        }

        SetTimerText();
    }

    private void SetTimerText()
        {
        // render change of time to current text
        timerText.text = currentTime.ToString("0.00");
        }
}
