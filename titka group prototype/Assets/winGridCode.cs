using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winGridCode : MonoBehaviour
{
    [SerializeField] private List<GameObject> winTriggersInGrid;
    [SerializeField] private bool allAreConnected;
    [SerializeField] private GameObject winIndicator;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            winTriggersInGrid.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        allAreConnected = true;
        foreach (GameObject winTrigger in winTriggersInGrid)
        {
            if (winTrigger.GetComponent<winTriggerCode>().connected == false)
            {
                allAreConnected = false;
                break; // No need to continue checking if one object has the property false
            }
        }
        
    }
}
