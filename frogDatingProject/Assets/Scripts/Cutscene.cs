using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public static int prevSceneNum = 1;
    // Start is called before the first frame update
    void Start()
    {
        prevSceneNum++;
        SceneManager.LoadScene("Scene"+prevSceneNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
