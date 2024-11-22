using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    [SerializeField] float spawnRate = 60f; //# of seconds between each customer spawn
    [SerializeField] GameObject spawnPosObject;
    [SerializeField] GameObject[] customers;

    private Vector3 spawnPos;
    private Queue<GameObject> customerQueue = new Queue<GameObject>();

    // private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosObject = GameObject.Find("CustomerSpawnLoc");
        spawnPos = spawnPosObject.transform.position;
        InvokeRepeating("SpawnCustomer", 5f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCustomer(){
        GameObject newCustomer = Instantiate(customers[0], spawnPos, Quaternion.identity);
        customerQueue.Enqueue(newCustomer);
        GameManager.instance.UpdateCount();
    }

    public void OrderTaken(){
        customerQueue.Peek();
    }

    public void DequeueCustomer(){
        Destroy(customerQueue.Dequeue());
    }
}
