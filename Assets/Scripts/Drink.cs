using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Drink : MonoBehaviour
{
    [SerializeField] private string teaFlavorOrdered;
    [SerializeField] private List<string> mixInsOrdered;
    [SerializeField] private List<string> toppingsOrdered;
    [SerializeField] private float steepTimeOrdered;

    [SerializeField] private string teaFlavor;
    [SerializeField] private List<string> mixIns;
    [SerializeField] private List<string> toppings;
    [SerializeField] private float steepTime;

    [SerializeField] TextMeshProUGUI drinkText;

    [SerializeField] bool canAdd;
    // GameManager gameManager;

    public string TeaFlavorOrdered {get => teaFlavorOrdered; set => teaFlavorOrdered = value; }
    public List<string> MixInsOrdered {get => mixInsOrdered; set => mixInsOrdered = value; }
    public List<string> ToppingsOrdered {get => toppingsOrdered; set => toppingsOrdered = value; }
    public float SteepTimeOrdered {get => steepTimeOrdered; set => steepTimeOrdered = value; }

    public string TeaFlavor {get => teaFlavor; set => teaFlavor = value; }
    public List<string> MixIns {get => mixIns; set => mixIns = value; }
    public List<string> Toppings {get => toppings; set => toppings = value; }
    public float SteepTime {get => steepTime; set => steepTime = value; }
    public bool CanAdd {get => canAdd; set => canAdd = value;}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDrinkText(){
        string lineSeperator = "--------------";

        drinkText.text = teaFlavorOrdered + "\n" + steepTimeOrdered + "s" + "\n" + lineSeperator + "\n" + mixInsOrdered[0]
        + "\n" + mixInsOrdered[1] + "\n" + lineSeperator + "\n" + toppingsOrdered[0] + "\n" + toppingsOrdered[1];
    }

    public void CallSelectObject(){
        GameManager.instance.selectObject(gameObject);
    }

    public int Score(){
        int score = 0;
        if(teaFlavor.Equals(teaFlavorOrdered)){
            score += 30;
        }

        if(steepTime > steepTimeOrdered - 5 && steepTime < steepTimeOrdered + 5){
            score += 10;
        }
        else if(steepTime > steepTimeOrdered - 5 && steepTime < steepTimeOrdered + 5 && steepTime < 65){
            score += 5;
        }

        if(mixIns.Contains(mixInsOrdered[0])){
            score += 15;
        }
        if(mixIns.Contains(mixInsOrdered[1])){
            score += 15;
        }

        if(toppings.Contains(toppingsOrdered[0])){
            score += 15;
        }
        if(toppings.Contains(toppingsOrdered[1])){
            score += 15;
        }

        score -= 5 * (mixIns.Count - 2);
        score -= 5 * (toppings.Count - 2);

        return score;
    }
}