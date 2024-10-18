using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    [SerializeField] float spawnRate = 120; //# of seconds between each customer spawn
    [SerializeField] GameObject spawnPosObject;

    private Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = spawnPosObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
