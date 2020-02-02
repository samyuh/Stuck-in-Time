using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] float miny;

    [SerializeField] float maxy;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(player.transform.position.y, miny, maxy), transform.position.z);
    }
}
