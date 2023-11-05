using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text phaseDisplayText;
    private Touch _theTouch;
    private float _timeTouchEnded;
    private float displayTime = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            _theTouch = Input.GetTouch(0);
            if (_theTouch.phase == TouchPhase.Ended)
            {
                phaseDisplayText.text = _theTouch.phase.ToString();
                _timeTouchEnded = Time.time;
            }
            else if (Time.time - _timeTouchEnded > displayTime)
            {
                phaseDisplayText.text = _theTouch.phase.ToString();
                _timeTouchEnded = Time.time;
            }
        }
        else if (Time.time - _timeTouchEnded > displayTime)
        {
            phaseDisplayText.text = "";
        }
    }

    private void Movement()
    {

    }
}
