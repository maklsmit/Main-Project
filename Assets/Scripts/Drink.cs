using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public string TeaFlavorOrdered {get => teaFlavorOrdered; set => teaFlavorOrdered = value; }
    public List<string> MixInsOrdered {get => mixInsOrdered; set => mixInsOrdered = value; }
    public List<string> ToppingsOrdered {get => toppingsOrdered; set => toppingsOrdered = value; }
    public float SteepTimeOrdered {get => steepTimeOrdered; set => steepTimeOrdered = value; }

    public string TeaFlavor {get => teaFlavor; set => teaFlavor = value; }
    public List<string> MixIns {get => mixIns; set => mixIns = value; }
    public List<string> Toppings {get => toppings; set => toppings = value; }
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