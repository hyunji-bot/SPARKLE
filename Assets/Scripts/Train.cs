using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    public GameObject player;
    public GameObject burger;
    public float speed;
    public Vector3 target;
    public Vector3 playerTarget;
    public Canvas trainCanvas;
    public Vector3 target2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!burger.activeSelf && player.transform.position.z < 2.4)
        {
            Debug.Log("기차움직이는중 ");
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, target, speed * Time.deltaTime);
            if (gameObject.transform.position.x == -14.5) burger.SetActive(true);
        }
    }

    void OnTriggerEnter()
    {
        trainCanvas.gameObject.SetActive(true);
        Debug.Log("기차");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            trainCanvas.gameObject.SetActive(false);
            player.transform.position = playerTarget;
            player.transform.rotation = Quaternion.Euler(0, 180, 0);
            player.GetComponent<PlayerMovement>().enabled = false;

            this.GetComponent<TrainEvent>().enabled = true;
        }
    }

    void StartTrain()
    {
        
    }
}
