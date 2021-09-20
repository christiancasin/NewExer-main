using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerCountdown : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 60;
    public bool takingAway = false;
    public string levelToLoad;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        if (secondsLeft == 0)
        {
            NextScene();
        }

        IEnumerator TimerTake()
        {
            takingAway = true;
            yield return new WaitForSeconds(1);
            secondsLeft -= 1;
            if (secondsLeft < 10)
            {
                textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
            }
            else
            {
                textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
            }
            takingAway = false;
        }
    }
    void NextScene()
    {
        if (secondsLeft == 0)
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}