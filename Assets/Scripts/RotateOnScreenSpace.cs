using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class RotateOnScreenSpace : MonoBehaviour
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
         if (Touch.activeTouches.Count == 1)
         { 
             if(Touch.activeTouches[0].phase == TouchPhase.Moved) 
             { 
                 transform.Rotate(-Touch.activeTouches[0].delta.y * 360 / Screen.height, 0, 0);
                 transform.Rotate(0, 0, -Touch.activeTouches[0].delta.x * 360 / Screen.width);
             } 
         }
         
         else if(Touch.activeTouches.Count == 3)
         {
             if(Touch.activeTouches[0].phase == TouchPhase.Moved && 
                Touch.activeTouches[1].phase == TouchPhase.Moved && 
                Touch.activeTouches[2].phase == TouchPhase.Moved) 
             { 
                 transform.Rotate(0, -Touch.activeTouches[0].delta.y * 360 / Screen.height, 0);
             } 
         }
    }
}
