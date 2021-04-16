using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour
{
    int width = 500;
    int height = 350;
    bool fullscreen;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(width, height, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
