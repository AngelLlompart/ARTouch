using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUI : MonoBehaviour
{

    private bool upIsPressed = false;
    private bool downIsPressed = false;
    private bool leftIsPressed = false;
    private bool rightIsPressed = false;
    private bool inIsPressed = false;
    private bool outIsPressed = false;

    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (upIsPressed)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (downIsPressed)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        
        if (leftIsPressed)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (rightIsPressed)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        
        if (inIsPressed)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (outIsPressed)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
    }

    public void MoveUpTouchDown()
    {
        Debug.Log("EE");
        upIsPressed = true;
    }
    
    public void MoveUpTouchUp()
    {
        upIsPressed = false;
    }
    
    public void MoveDownTouchDown()
    {
        downIsPressed = true;
    }
    
    public void MoveDownTouchUp()
    {
        downIsPressed = false;
    }
    
    public void MoveLeftTouchDown()
    {
        leftIsPressed = true;
    }
    
    public void MoveLeftTouchUp()
    {
        leftIsPressed = false;
    }
    
    public void MoveRightTouchDown()
    {
        rightIsPressed = true;
    }
    
    public void MoveRightTouchUp()
    {
        rightIsPressed = false;
    }
    
    public void MoveInTouchDown()
    {
        inIsPressed = true;
    }
    
    public void MoveInTouchUp()
    {
        inIsPressed = false;
    }
    
    public void MoveOutTouchDown()
    {
        outIsPressed = true;
    }
    
    public void MoveOutTouchUp()
    {
        outIsPressed = false;
    }
}
