using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkManager : MonoBehaviour
{
    [SerializeField] GameObject drinkPrefab;
    [SerializeField] Transform drinkPreview;

    private string[] TeaFlavors = {"Green", "Black", "Oolong"};
    private float[] SteepTimes = {10f, 15f, 20f, 50f, 30f}; //In seconds
    private string[] MixInOptions = {"Strawberry Syrup", "Milk", "Blueberry Syrup"};
    private string[] ToppingOptions = {"Ice", "Tapioca Pearls", "Boba"};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateDrink(){
        // Drink newDrink = new Drink(); //DON'T KEEP need to have it spawn a drink object not just a script
        Drink newDrink = Instantiate(drinkPrefab, drinkPreview.position, Quaternion.identity).GetComponent<Drink>();
        newDrink.TeaFlavorOrdered = TeaFlavors[Random.Range(0, TeaFlavors.Length)];

        newDrink.SteepTimeOrdered = SteepTimes[Random.Range(0, SteepTimes.Length)];

        string[] tempMixIns = new string[2];
        tempMixIns[0] = (MixInOptions[Random.Range(0, MixInOptions.Length)]);
        tempMixIns[1] = (MixInOptions[Random.Range(0, MixInOptions.Length)]);
        newDrink.MixInsOrdered = tempMixIns;

        string[] tempToppings = new string[2];
        tempToppings[0] = (ToppingOptions[Random.Range(0, ToppingOptions.Length)]);
        tempToppings[1] = (ToppingOptions[Random.Range(0, ToppingOptions.Length)]);
        newDrink.ToppingsOrdered = tempToppings;
    }
}
