using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : MonoBehaviour
{
    [SerializeField] private string teaFlavorOrdered;
    [SerializeField] private string[] mixInsOrdered;
    [SerializeField] private string[] toppingsOrdered;
    [SerializeField] private float steepTimeOrdered;

    private string teaFlavor;
    private string[] mixIns;
    private string[] toppings;
    private float steepTime;

    public string TeaFlavorOrdered {get => teaFlavorOrdered; set => teaFlavorOrdered = value; }
    public string[] MixInsOrdered {get => mixInsOrdered; set => mixInsOrdered = value; }
    public string[] ToppingsOrdered {get => toppingsOrdered; set => toppingsOrdered = value; }
    public float SteepTimeOrdered {get => steepTimeOrdered; set => steepTimeOrdered = value; }

    public string TeaFlavor {get => teaFlavor; set => teaFlavor = value; }
    public string[] MixIns {get => mixIns; set => mixIns = value; }
    public string[] Toppings {get => toppings; set => toppings = value; }
    public float SteepTime {get => steepTime; set => steepTime = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}