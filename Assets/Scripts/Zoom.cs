using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;
public class Zoom : MonoBehaviour
{
    private Vector2 pos1;
    private Vector2 pos2;

    private Vector3 scale = new Vector3(0.1f, 0.1f, 0.1f);
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Touch.activeTouches.Count == 2)
        {
            if (Touch.activeTouches[0].phase == TouchPhase.Began)
            {
                pos1 = Touch.activeTouches[0].screenPosition;
            }
            if (Touch.activeTouches[1].phase == TouchPhase.Began)
            {
                pos2 = Touch.activeTouches[1].screenPosition;
            }

            float distanceIni = Vector2.Distance(pos1, pos2);
            
            if(Touch.activeTouches[0].phase == TouchPhase.Moved || Touch.activeTouches[1].phase == TouchPhase.Moved)
            {
                float distance = Vector2.Distance(Touch.activeTouches[0].screenPosition, Touch.activeTouches[1].screenPosition);
                if (distance > distanceIni)
                {
                   ZoomIn();
                }
                else if (distance < distanceIni)
                {
                   ZoomOut();
                }
            }
        }
    }

    public void ZoomIn()
    {
        if (transform.localScale.y < 2)
        {
            transform.localScale += scale;
        }
    }

    public void ZoomOut()
    {
        if (transform.localScale.y > 0.2f)
        {
            transform.localScale -= scale;
        }
    }
}
