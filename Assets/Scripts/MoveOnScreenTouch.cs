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
        if (_changeTouchManager.isRotation == false)
        {
            if (Touch.activeTouches.Count == 1)
            {
                if (Touch.activeTouches[0].phase == TouchPhase.Moved)
                {
                    transform.position += Vector3.right * Touch.activeTouches[0].delta.x * Time.deltaTime;
                    transform.position += Vector3.up * Touch.activeTouches[0].delta.y * Time.deltaTime;
                }
            }

            else if (Touch.activeTouches.Count == 3)
            {
                if (Touch.activeTouches[0].phase == TouchPhase.Moved &&
                    Touch.activeTouches[1].phase == TouchPhase.Moved &&
                    Touch.activeTouches[2].phase == TouchPhase.Moved)
                {
                    transform.position += Vector3.forward * Touch.activeTouches[0].delta.y * Time.deltaTime;
                }
            }
        }
    }
}
