using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
 public int minutes=5;
 public float seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds > 0) {
            seconds -= Time.deltaTime;
        }
        else if (minutes > 0) { seconds += 60 - Time.deltaTime;
            minutes -= 1;
        }
        else {
SceneManager.LoadScene("Scene_Name");
        }
    }
