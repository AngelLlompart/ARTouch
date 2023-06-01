using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUI : MonoBehaviour
{
    private bool xuIsPressed = false;
    private bool xdIsPressed = false;
    private bool ylIsPressed = false;
    private bool yrIsPressed = false;
    private bool zuIsPressed = false;
    private bool zdIsPressed = false;
    
    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (xuIsPressed)
        {
            transform.Rotate(-rotationSpeed, 0,0);
        }
        
        if (xdIsPressed)
        {
            transform.Rotate(rotationSpeed, 0,0);
        }
        
        if (ylIsPressed)
        {
            transform.Rotate(0, 0,-rotationSpeed);
        }
        
        if (yrIsPressed)
        {
            transform.Rotate(0, 0,rotationSpeed);
        }
        
        if (zuIsPressed)
        {
            transform.Rotate(0, -rotationSpeed,0);
        }
        
        if (zdIsPressed)
        {
            transform.Rotate(0, rotationSpeed,0);
        }
    }
    
    
    public void XuTouchDown()
    {
        xuIsPressed = true;
    }
    
    public void XuTouchUp()
    {
        xuIsPressed = false;
    }
    
    public void XdTouchDown()
    {
        xdIsPressed = true;
    }
    
    public void XdTouchUp()
    {
        xdIsPressed = false;
    }
    
    public void YlTouchDown()
    {
        ylIsPressed = true;
    }
    
    public void YlTouchUp()
    {
        ylIsPressed = false;
    }
    
    public void YrTouchDown()
    {
        yrIsPressed = true;
    }
    
    public void YrTouchUp()
    {
        yrIsPressed = false;
    }
    
    public void ZuTouchDown()
    {
        zuIsPressed = true;
    }
    
    public void ZuTouchUp()
    {
        zuIsPressed = false;
    }
    
    public void ZdTouchDown()
    {
        zdIsPressed = true;
    }
    
    public void ZdTouchUp()
    {
        zdIsPressed = false;
    }
}
