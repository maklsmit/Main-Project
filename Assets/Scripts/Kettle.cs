using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kettle : MonoBehaviour
{
    private float timeStartSteep;
    [SerializeField] private float timeEndSteep;
    private string teaFlavor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeStartSteep != 0){
            timeEndSteep = Time.time;
        }
    }

    public void StartSteep(string tea){
        timeStartSteep = Time.time;
        teaFlavor = tea;
    }

    public void EndSteep(GameObject drink){
        if(drink.GetComponent<Drink>() != null){
            drink.GetComponent<Drink>().TeaFlavor = teaFlavor;
            drink.GetComponent<Drink>().SteepTime = timeEndSteep - timeStartSteep;
            timeEndSteep = 0;
            timeStartSteep = 0;
            teaFlavor = "";
        }
    }
}
