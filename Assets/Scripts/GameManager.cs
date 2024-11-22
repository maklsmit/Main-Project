using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    [SerializeField] private UIManager uiManager;
    [SerializeField] private GameObject selectedObject;
    [SerializeField] private GameObject mixInsPositioner;
    [SerializeField] private GameObject toppingsPositioner;
    [SerializeField] private Transform mainCanvas;
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private TextMeshProUGUI scoreText;

    private int customerCount = 10;
    private int score = 0;

    Queue<GameObject> mixInsQueue = new Queue<GameObject>();
    Queue<GameObject> toppingsQueue = new Queue<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectObject(GameObject obj){
        if(obj.tag == "station"){
            selectedObject = null;
        }
        else if(obj.tag == "next"){
            GameObject movingDrink;
            if(mixInsQueue.Count > 0){
                movingDrink = mixInsQueue.Dequeue();
                movingDrink.SetActive(false);
                movingDrink.transform.position = toppingsPositioner.transform.position;
                toppingsQueue.Enqueue(movingDrink);
                uiManager.SetParentTopping(movingDrink);
            }
            
            toppingsQueue.Peek().SetActive(true);  

            if(mixInsQueue.Count > 0){
                mixInsQueue.Peek().SetActive(true);
            }
        }
        else if(obj.tag == "done"){
            if(toppingsQueue.Count > 0){
                GameObject scoreDrink = toppingsQueue.Dequeue();
                UpdateScore(scoreDrink);
                Destroy(scoreDrink);
            }
            if(toppingsQueue.Count > 0){
                toppingsQueue.Peek().SetActive(true);
            }
            else if(customerCount <= 0){
                SceneLoader.instance.LoadNewScene("EndScene");
            }
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
            MoveDrink(.43f, .44f, obj, false);
        }
        else if(selectedObject.tag == "drink" && obj.tag == "preview"){
            MoveDrink(1, 1, obj, false);
        }
        else if(selectedObject.tag == "drink" && obj.tag == "adder"){
            MoveDrink(.75f, .75f, obj, true);
        }
        else if(selectedObject.tag == "tea" && obj.tag == "kettle"){
            obj.GetComponent<Kettle>().StartSteep(selectedObject.name.Substring(0, selectedObject.name.Length - 9));
            selectedObject = null;
        }
        else if(obj.tag == "drink" && obj.GetComponent<Drink>().CanAdd){
            if(selectedObject.tag == "mixin"){
                obj.GetComponent<Drink>().MixIns.Add(selectedObject.name);
                selectedObject = null;
            }
            else if(selectedObject.tag == "topping"){
                obj.GetComponent<Drink>().Toppings.Add(selectedObject.name);
                selectedObject = null;
            }
            else if(selectedObject.tag == "kettle" && obj.tag == "drink"){
                selectedObject.GetComponent<Kettle>().EndSteep(obj);
                selectedObject = null;
                obj.SetActive(false);
                mixInsQueue.Enqueue(obj);
                obj.transform.position = mixInsPositioner.transform.position;
                obj.transform.localScale = new Vector3(1, 1, 1);
                mixInsQueue.Peek().SetActive(true);
                uiManager.SetParentMixIn(obj);
            }
        }
        
        else{
            selectedObject = obj;
        }
    }

    private void MoveDrink(float xScale, float yScale, GameObject obj, bool isAdder){
        selectedObject.transform.localScale = new Vector3(xScale, yScale, 1);
        selectedObject.transform.position = obj.transform.position;
        selectedObject.GetComponent<Drink>().CanAdd = isAdder;

        if(isAdder){
            uiManager.SetParentSteep(selectedObject);
        }
        else{
            selectedObject.transform.SetParent(mainCanvas, false);
        }
        selectedObject = null;
    }

    private void UpdateScore(GameObject drink){
        score += drink.GetComponent<Drink>().Score();
        scoreText.text = "Score: " + score;
        SceneLoader.instance.SetScoreText(score);
    }

    public void UpdateCount(){
        customerCount -= 1;
        countText.text = "Customers left: " + customerCount;
    }
}
