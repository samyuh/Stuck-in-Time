using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_one_specific_sound_for_credits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManagerScript.PlaySound("win");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
