using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimersCountdown: MonoBehaviour
{
    public TMP_Text lapTime;
    public TMP_Text startCountdown;
    public float totalLapTime;
    public float totalCountdownTime;
    
    // Update is called once per frame
    void Update()
    {
        totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;
        lapTime.text = totalLapTime.ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
    }
}
