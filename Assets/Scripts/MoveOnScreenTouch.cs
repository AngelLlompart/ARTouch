using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class MoveOnScreenTouch : MonoBehaviour
{
    private ChangeTouchManager _changeTouchManager;
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _changeTouchManager = FindObjectOfType<ChangeTouchManager>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_changeTouchManager.isRotation)
        {
            if (Touch.activeTouches.Count == 1)
            {
                if (Touch.activeTouches[0].phase == TouchPhase.Moved)
                {
                    transform.Translate(-Touch.activeTouches[0].delta.x  / Screen.width, 0, 0);
                    transform.Translate(0, -Touch.activeTouches[0].delta.y * 100, 0);
                }
            }

            else if (Touch.activeTouches.Count == 3)
            {
                if (Touch.activeTouches[0].phase == TouchPhase.Moved &&
                    Touch.activeTouches[1].phase == TouchPhase.Moved &&
                    Touch.activeTouches[2].phase == TouchPhase.Moved)
                {
                    transform.Rotate(0, 0, -Touch.activeTouches[0].delta.y  / Screen.height);
                }
            }
        }
    }
}
