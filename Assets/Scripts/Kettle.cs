using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kettle : MonoBehaviour
{
    private float timeStartSteep;
    [SerializeField] private float timeEndSteep;
    [SerializeField] private string teaFlavor;
    [SerializeField] private GameObject slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeStartSteep != 0){
            timeEndSteep = Time.time;
            float timeValue = (timeEndSteep - timeStartSteep)/60;
            slider.GetComponent<Slider>().value = timeValue;
            if(timeValue >= 1.083f){
                Debug.Log("Time too far");
                slider.GetComponent<Slider>().transform.GetChild(1).transform.GetChild(0).GetComponent<Image>().color = Color.black;
            }
        }
    }

    public void StartSteep(string tea){
        timeStartSteep = Time.time;
        teaFlavor = tea;
    }

    public void EndSteep(GameObject drink){
        if(drink.GetComponent<Drink>() != null){
            // Debug.Log("End steep AND if statement called");
            drink.GetComponent<Drink>().TeaFlavor = teaFlavor;
            drink.GetComponent<Drink>().SteepTime = timeEndSteep - timeStartSteep;
            timeEndSteep = 0;
            timeStartSteep = 0;
            teaFlavor = "";
            slider.GetComponent<Slider>().value = 0;
        }
    }
}
