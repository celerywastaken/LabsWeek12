using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class VirtualDPad : MonoBehaviour
{

    public TextMeshProUGUI directionText;
    private Touch theTouch;
    private Vector2 touchStartingPosition, touchEndingPosition;
    private string direction;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            if(theTouch.phase == TouchPhase.Began)
            {
                touchStartingPosition = theTouch.position;
            }
            else if (theTouch.phase == TouchPhase.Moved || theTouch.phase == TouchPhase.Ended)
            {
                touchEndingPosition = theTouch.position;
                float x = touchEndingPosition.x - touchStartingPosition.x;
                float y = touchEndingPosition.y - touchStartingPosition.y;

                if(Mathf.Abs(x) == 0 && Mathf.Abs(y) == 0)
                {
                    direction = "Tapped";
                }
                else if (Mathf.Abs(x) > Mathf.Abs(y))
                {
                    direction = x > 0 ? "right" : "left";
                }
                else
                {
                    direction = y > 0 ? "Up" : "Down";
                }
            } 
        }
        directionText.text = direction;
    }
}
