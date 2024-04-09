using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class demoSceneTransitions : MonoBehaviour
{
    float timer;
    [SerializeField] float holdDur = 3f;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Equals))
        {
            timer = Time.time;
        }
        else if(Input.GetKey(KeyCode.Equals))
        {
            if(Time.time - timer > holdDur)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        if(Input.GetKeyDown(KeyCode.Minus))
        {
            timer = Time.time;
        }
        else if(Input.GetKey(KeyCode.Minus))
        {
            if(Time.time - timer > holdDur)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            timer = Time.time;
        }
        else if(Input.GetKey(KeyCode.Alpha0))
        {
            if(Time.time - timer > holdDur)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
