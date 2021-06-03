using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter(Collider triggerInfo)
    {

        if(triggerInfo.name == "Player")
        {
            gameManager.CompleteLevel();
        }   
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
