using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainEvent : MonoBehaviour
{
    public Vector3 target;
    public float speed;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, target, speed * Time.deltaTime);
        player.transform.position = Vector3.MoveTowards(player.transform.position, target - new Vector3(15, 0, 0), speed * Time.deltaTime);
    }
}
