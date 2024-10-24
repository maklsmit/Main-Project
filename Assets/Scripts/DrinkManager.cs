using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkManager : MonoBehaviour
{
    private string[] TeaFlavors = {"Green", "Black"};
    private string[] MixInOptions = {"Strawberry Syrup", "Ice"};
    // Start is called before the first frame update
    void Start()
    {
        CreateDrink();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateDrink(){
        Drink newDrink = new Drink(); //DON'T KEEP need to have it spawn a drink object not just a script
        newDrink.TeaFlavor = TeaFlavors[Random.Range(0, TeaFlavors.Length)];
        string[] tempMixIns = new string[2];
        for(int i = 0; i < 2; i++){
            tempMixIns[i] = (MixInOptions[Random.Range(0, MixInOptions.Length)]);
        }
        newDrink.MixIns = tempMixIns;
        Debug.Log(newDrink.TeaFlavor);
        Debug.Log(newDrink.MixIns);
    }
}
