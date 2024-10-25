using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkManager : MonoBehaviour
{
    [SerializeField] GameObject drinkPrefab;
    private string[] TeaFlavors = {"Green", "Black", "Oolong"};
    private float[] SteepTimes = {10f, 15f, 20f, 50f, 30f}; //In seconds
    private string[] MixInOptions = {"Strawberry Syrup", "Milk", "Blueberry Syrup"};
    private string[] ToppingOptions = {"Ice", "Tapioca Pearls", "Boba"};
    // Start is called before the first frame update
    void Start()
    {
        CreateDrink();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateDrink(){
        // Drink newDrink = new Drink(); //DON'T KEEP need to have it spawn a drink object not just a script
        Drink newDrink = Instantiate(drinkPrefab).GetComponent<Drink>();
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
