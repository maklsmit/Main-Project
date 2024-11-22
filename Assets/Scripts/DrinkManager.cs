using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkManager : MonoBehaviour
{
    [SerializeField] GameObject drinkPrefab;
    [SerializeField] Transform drinkPreview;
    [SerializeField] Transform mainCanvas;

    private string[] TeaFlavors = {"Green", "Black", "Oolong"};
    private float[] SteepTimes = {30f, 15f, 45f, 60f}; //In seconds
    private string[] MixInOptions = {"Strawberry", "Milk", "Blueberry", "Honey", "Vanilla", "Lemon"};
    private string[] ToppingOptions = {"Ice", "Tapioca Pearls", "Boba", "Rainbow Jelly", "Cheese Foam", "Berries"};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateDrink(){
        GameObject drinkObj = Instantiate(drinkPrefab, drinkPreview.position, Quaternion.identity);
        drinkObj.transform.SetParent(mainCanvas, false);
        Drink newDrink = drinkObj.GetComponent<Drink>();
        newDrink.TeaFlavorOrdered = TeaFlavors[Random.Range(0, TeaFlavors.Length)];

        newDrink.SteepTimeOrdered = SteepTimes[Random.Range(0, SteepTimes.Length)];

        // tempMixIns[0] = (MixInOptions[Random.Range(0, MixInOptions.Length)]);
        // tempMixIns[1] = (MixInOptions[Random.Range(0, MixInOptions.Length)]);
        newDrink.MixInsOrdered.Add(MixInOptions[Random.Range(0, MixInOptions.Length)]);
        newDrink.MixInsOrdered.Add(MixInOptions[Random.Range(0, MixInOptions.Length)]);

        // tempToppings[0] = (ToppingOptions[Random.Range(0, ToppingOptions.Length)]);
        // tempToppings[1] = ;
        newDrink.ToppingsOrdered.Add(ToppingOptions[Random.Range(0, ToppingOptions.Length)]);
        newDrink.ToppingsOrdered.Add(ToppingOptions[Random.Range(0, ToppingOptions.Length)]);

        newDrink.UpdateDrinkText();
    }

    
}
