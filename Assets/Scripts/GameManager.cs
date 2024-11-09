using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if(selectedObject == null){
            selectedObject = obj;
        }
        else if(obj == null){
            selectedObject = null;
        }
        else{
            interactable(selectedObject, obj);
        }
    }

    private void interactable(GameObject selectedObject, GameObject obj){
        if(selectedObject.GetComponent<Drink>() != null && obj.tag == "positioner"){
            selectedObject.transform.position = obj.transform.position;
        }
        else if(selectedObject.GetComponent<Kettle>() != null && obj.GetComponent<Drink>() != null){
            selectedObject.GetComponent<Kettle>().EndSteep(obj);
        }
        else if(selectedObject.tag == "tea" && obj.GetComponent<Kettle>() != null){
            obj.GetComponent<Kettle>().StartSteep(selectedObject.name);
        }
    }
}
