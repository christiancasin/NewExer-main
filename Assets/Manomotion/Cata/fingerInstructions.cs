using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fingerInstructions : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 240;
    public bool takingAway = false;
    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "INDEX";
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if ((secondsLeft == 240))
        {
            textDisplay.GetComponent<Text>().text = "INDEX";
        }
        else if ((secondsLeft == 180))
        {
            textDisplay.GetComponent<Text>().text = "MIDDLE";
        }
        else if ((secondsLeft == 120))
        {
            textDisplay.GetComponent<Text>().text = "RING";
        }
        else if ((secondsLeft == 60))
        {
            textDisplay.GetComponent<Text>().text = "PINKY";
        }
        else if ((secondsLeft == 0))
        {
            textDisplay.GetComponent<Text>().text = " ";
        }
        takingAway = false;
    }
}