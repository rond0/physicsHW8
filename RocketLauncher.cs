using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    [SerializeField] float timerLength;
    [SerializeField] float timeRemaining;
    [SerializeField] GameObject rocket;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timerLength;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Instantiate (rocket,new Vector3(transform.position.x,transform.position.y+0.8f),rocket.transform.rotation);
            timeRemaining = timerLength;
        }
    }
}
