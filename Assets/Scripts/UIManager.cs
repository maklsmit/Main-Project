using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject orderPanel;
    [SerializeField] GameObject steepPanel;
    [SerializeField] GameObject mixinsPanel;
    [SerializeField] GameObject toppingsPanel;

    private GameObject currentPanel;

    // Start is called before the first frame update
    void Start()
    {
        currentPanel = orderPanel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changePanel(GameObject panel){
        currentPanel.SetActive(false);
        panel.SetActive(true);
        currentPanel = panel;
    }

    public void flipActiveButton(GameObject button){
        button.SetActive(!button.activeSelf);
    }

    public void SetParentSteep(GameObject drink){
        drink.transform.SetParent(steepPanel.transform, false);
    }

    public void SetParentMixIn(GameObject drink){
        drink.transform.SetParent(mixinsPanel.transform, false);
    }

    public void SetParentTopping(GameObject drink){
        drink.transform.SetParent(toppingsPanel.transform, false);
    }
}
