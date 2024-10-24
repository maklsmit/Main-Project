using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    [SerializeField] float spawnRate = 120; //# of seconds between each customer spawn
    [SerializeField] GameObject spawnPosObject;
    [SerializeField] GameObject[] customers;

    private Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = spawnPosObject.transform.position;
        InvokeRepeating("SpawnCustomer", 5f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCustomer(){
        Instantiate(customers[0], spawnPos, Quaternion.identity);
    }
}
