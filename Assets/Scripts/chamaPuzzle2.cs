using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chamaPuzzle2 : MonoBehaviour
{
    bool primeira;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        primeira=true;
        t=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(ManagePuzzleGame.fim){
            t+=Time.deltaTime;
            if(t>5){
                primeira=false;
                SceneManager.LoadScene("PuzzleAudios_2");
            }
        }
    }
}
