using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private OpenPortal dMan;

    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<OpenPortal>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (dMan.portal)
        {
            SceneManager.LoadScene("Credits");
        }

    }
}
