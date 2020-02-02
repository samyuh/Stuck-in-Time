using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaveGear : MonoBehaviour
{
    private GetGear dMan;
    public bool DestroyedGear = false;

    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<GetGear>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (dMan.HaveGear)
        {
            Destroy(gameObject);
            DestroyedGear = true;
        }
 
    }

}
