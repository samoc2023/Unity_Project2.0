using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    private Vector3 offset = new Vector3(-105, 278, -356);

    private Rigidbody playerRb;
    public GameObject focalPoint;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
       // playerRb.AddForce(Vector3.forward focalPoint.transform.forward
        //* speed * Time.deltaTime);
    }
}
