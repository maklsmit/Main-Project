using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject selectedObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectObject(GameObject obj){
        if(obj.tag == "station"){
            selectedObject = null;
        }
        else if(selectedObject == null){
            selectedObject = obj;
            Debug.Log("In the else if statement, selected obj = " + selectedObject);
        }
        else{
          interactable(obj);
        }
        Debug.Log(selectedObject);
    }

    private void interactable(GameObject obj){
        if(selectedObject.tag == "drink" && obj.tag == "positioner"){
            selectedObject.transform.localScale = new Vector3(0.43f, 0.44f, 1);
            selectedObject.transform.position = obj.transform.position;
            selectedObject = null;
        }
        else if(selectedObject.tag == "drink" && obj.tag == "preview"){
            selectedObject.transform.localScale = new Vector3(1, 1, 1);
            selectedObject.transform.position = obj.transform.position;
            selectedObject = null;
        }
        else if(selectedObject.tag == "kettle" && obj.tag == "drink"){
            selectedObject.GetComponent<Kettle>().EndSteep(obj);
            selectedObject = null;
        }
        else if(selectedObject.tag == "tea" && obj.tag == "kettle"){
            obj.GetComponent<Kettle>().StartSteep(selectedObject.name.Substring(0, selectedObject.name.Length - 6));
            selectedObject = null;
        }
        else if(selectedObject.tag == "mixin" && obj.tag == "drink"){
            obj.GetComponent<Drink>().MixIns.Add(selectedObject.name);
            selectedObject = null;
        }
        else if(selectedObject.tag == "topping" && obj.tag == "drink"){
            obj.GetComponent<Drink>().Toppings.Add(selectedObject.name);
            selectedObject = null;
        }
        else{
            selectedObject = obj;
        }
    }
}
