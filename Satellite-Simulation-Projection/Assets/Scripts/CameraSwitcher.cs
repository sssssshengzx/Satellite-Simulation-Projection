using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera AICamera;
    public Camera OtherCamera;
    // Start is called before the first frame update
    void Start()
    {
        AICamera.enabled = true;
        OtherCamera.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            AICamera.enabled = !AICamera.enabled;
            OtherCamera.enabled = !OtherCamera.enabled;
        }
    }
}
