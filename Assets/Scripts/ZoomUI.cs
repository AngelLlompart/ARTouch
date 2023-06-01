using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomUI : MonoBehaviour
{
    private bool zoomInIsPressed = false;
    private bool zoomOutIsPressed = false;
    
    private Vector3 scale = new Vector3(0.1f, 0.1f, 0.1f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.y < 2 && zoomInIsPressed)
        {
            transform.localScale += scale;
        }
    
        if (transform.localScale.y > 0.2f && zoomOutIsPressed)
        {
            
            transform.localScale -= scale;
        }
    }
    
    public void ZoomInTouchDown()
    {
        zoomInIsPressed = true;
    }

    public void ZoomInTouchUp()
    {
        zoomInIsPressed = false;
    }
    
    public void ZoomOutTouchDown()
    {
        zoomOutIsPressed = true;
    }

    public void ZoomOutTouchUp()
    {
        zoomOutIsPressed = false;
    }
}
