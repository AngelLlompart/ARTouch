using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTouchManager : MonoBehaviour
{
    public bool isRotation;

    [SerializeField] private Image changeTouch;

    [SerializeField] private Sprite rotation;
    
    [SerializeField] private Sprite translation;
    
    // Start is called before the first frame update
    void Start()
    {
        isRotation = true;
        changeTouch.sprite = translation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ImageChangeTouch(){
    
        if (isRotation)
        {
            isRotation = false;
            changeTouch.sprite = rotation;
        }
        else
        {
            changeTouch.sprite = translation;
            isRotation = true;
        }
    }
}
