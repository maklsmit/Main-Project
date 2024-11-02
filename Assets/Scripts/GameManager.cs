using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private GameObject selectedObject;
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
        else if(interactable(selectedObject, obj)){

        }
    }

    private bool interactable(GameObject selectedObject, GameObject obj){
        if(selectedObject.GetComponent<Drink>() != null){
            if(obj.tag == "positioner"){
                return true;
            }
        }

        return false;
    }
}
