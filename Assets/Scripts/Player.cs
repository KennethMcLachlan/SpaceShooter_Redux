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

    private Vector3 _position;
    private float width;
    private float height;


    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        //width = (float)Screen.width / 8.0f;
        //height = (float)Screen.height / 15.0f;

        _position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        ////Touch Screen Example

        //if (Input.touchCount > 0)
        //{
        //    _theTouch = Input.GetTouch(0);
        //    if (_theTouch.phase == TouchPhase.Ended)
        //    {
        //        phaseDisplayText.text = _theTouch.phase.ToString();
        //        _timeTouchEnded = Time.time;
        //    }
        //    else if (Time.time - _timeTouchEnded > displayTime)
        //    {
        //        phaseDisplayText.text = _theTouch.phase.ToString();
        //        _timeTouchEnded = Time.time;
        //    }
        //}
        //else if (Time.time - _timeTouchEnded > displayTime)
        //{
        //    phaseDisplayText.text = "";
        //}
    }

    private void Movement()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);


            //Move the Cube if finger is moving

            //if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            //{
            //    Vector2 touchPosition;

            //    touchPosition = Camera.main.ScreenToWorldPoint(new Vector2(touch.position.x, touch.position.y));

            //    transform.position = touchPosition;
            //}

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 34.0f));


                transform.position = touchPosition;
            }
            else if (touch.phase == TouchPhase.Canceled)
            {
                transform.position = _position;
            }

            //if (touch.phase == TouchPhase.Moved)
            //{
            //    Vector2 pos = touch.position;
            //    pos.x = (pos.x - width) / width;
            //    pos.y = (pos.y - height) / height;
            //    _position = new Vector3(-pos.x, pos.y, 0.0f);

            //    //Position the Cube
            //    transform.position = _position;
            //}
        }
    }
    
}
