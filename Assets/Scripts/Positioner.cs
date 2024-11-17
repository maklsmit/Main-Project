using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positioner : MonoBehaviour
{
    [SerializeField] bool drinkInPosition;

    public bool DrinkInPosition {get => drinkInPosition; set => drinkInPosition = value; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchBool(){
        if(drinkInPosition == false){
            drinkInPosition = true;
        }
        else{
            drinkInPosition = false;
        }
    }

}
