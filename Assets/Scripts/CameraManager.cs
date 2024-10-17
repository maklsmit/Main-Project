using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // enum CurrentCam{
    //     OrderCam,
    //     SteepCam,
    //     MixCam,
    //     ToppingsCam
    // }
    [SerializeField] private Camera orderCam;
    [SerializeField] private Camera steepCam;
    [SerializeField] private Camera MixCam;
    [SerializeField] private Camera ToppingsCam;
    // CurrentCam currentCam;
    private Camera currentCam;

    
    void Start()
    {
        // CurrentCam.OrderCam = orderCam;
        currentCam = orderCam;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchCam(Camera newCam){
        if(newCam != currentCam){
            currentCam.enabled = false;
            newCam.enabled = true;
            currentCam = newCam;
        }        
    }
}
