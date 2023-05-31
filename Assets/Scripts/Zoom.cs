using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;
public class Zoom : MonoBehaviour
{
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
            Vector2 pos1 = Vector2.zero;
            Vector2 pos2 = Vector2.zero;
            if (Touch.activeTouches[1].phase == TouchPhase.Began)
            {
                pos2 = Touch.activeTouches[1].delta;
            }
            if (Touch.activeTouches[0].phase == TouchPhase.Began)
            {
                pos1 = Touch.activeTouches[0].delta;
            }
            if(Touch.activeTouches[0].phase == TouchPhase.Moved || Touch.activeTouches[1].phase == TouchPhase.Moved) 
            { 
                
            }
        }
    }
}
