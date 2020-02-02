using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaveClock : MonoBehaviour
{
    private GetClock dMan;
    public bool DestroyedClock = false; 

    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<GetClock>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (dMan.HaveClock)
        {
            Destroy(gameObject);
            DestroyedClock = true;
        }

    }

}
