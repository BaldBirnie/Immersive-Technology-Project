using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMD_Manager : MonoBehaviour
{
    [SerializeField] GameObject xrPlayer;
    [SerializeField] GameObject fpsPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HMD:" + XRSettings.loadedDeviceName);
        if (XRSettings.isDeviceActive || XRSettings.loadedDeviceName == "OpenXR Display")
        {
            Debug.Log("Using device XR Player with HMD " + XRSettings.loadedDeviceName);
            fpsPlayer.SetActive(false);
            xrPlayer.SetActive(true);
        }
        else
        {
            Debug.Log("Using device XR Player with HMD " + XRSettings.loadedDeviceName);
            fpsPlayer.SetActive(true);
            xrPlayer.SetActive(false);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
