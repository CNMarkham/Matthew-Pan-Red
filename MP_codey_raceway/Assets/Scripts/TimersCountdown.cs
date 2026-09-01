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
    public CodeyMove codey;
    
    // Update is called once per frame
    void Update()
    {
        lapTime.text = totalLapTime.ToString();

        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            codey.canMove = false;
        }

        if (totalCountdownTime <= 0)
        {
            startCountdown.text = string.Empty;
            totalLapTime -= Time.deltaTime;
            codey.canMove = true;
        }

        if (totalLapTime <= 0)
        {
            codey.canMove = false;
            print("get gud");
        }
    }
}
