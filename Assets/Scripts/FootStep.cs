using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    float moveX;
    public GameObject player;
    Rigidbody rb;
    AudioSource audioSrc;
    bool isMoving = false;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        pos = player.transform.position;
        //rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //MoveSfx();
    }

    void MoveSfx()
    {  
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            Debug.Log("발자국");
            isMoving = true;
            //pos = player.transform.position;
        }

        else 
        {
            audioSrc.Stop();
            isMoving = false;
        }
            

        if (isMoving)
        {
            Debug.Log("여기?");
            if (!audioSrc.isPlaying)
                audioSrc.Play();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        MoveSfx();
        Debug.Log("발자국소리 시작");
    }
    private void OnTriggerExit(Collider other)
    {
        audioSrc.Stop();
        Debug.Log("발자국소리 끝");
    }
}
