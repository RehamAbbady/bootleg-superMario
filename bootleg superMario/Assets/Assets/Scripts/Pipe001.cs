using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
using UnityStandardAssets.Characters.ThirdPerson;

public class Pipe001 : MonoBehaviour
{
    public GameObject pipe_entry;
    public int StoodOn;


    private void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;
    }

    private void OnTriggerExit(Collider col)
    {
        StoodOn = 0;
    }

    IEnumerator WaitPipeAnimation()
    {
        yield return new WaitForSeconds(2);
        pipe_entry.GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("GoDown"))
        {
            if (StoodOn == 1)
            {
                transform.position = new Vector3(0, -1000, 0);
                WaitingForPipe();
            }
        }
    }

    public void WaitingForPipe()
    {
        pipe_entry.GetComponent<Animator>().enabled = true;
        StartCoroutine("WaitPipeAnimation");
    }

    // Start is called before the first frame update
    void Start()
    {


    }
}