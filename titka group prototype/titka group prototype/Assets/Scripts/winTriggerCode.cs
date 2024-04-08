using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class winTriggerCode : MonoBehaviour
{

    public bool connected;
    [SerializeField] private pipeLogic connectedScript;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (connectedScript && connectedScript.conected)
        {
            connected = true;
            //gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        } else
        {
            connected = false;
            //gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        connectedScript = other.gameObject.GetComponent<pipeLogic>();
    }

}
