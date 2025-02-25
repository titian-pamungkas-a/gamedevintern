using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed;
    private float updatedSpeed;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (panel.activeSelf) updatedSpeed = 0f;
        else updatedSpeed = speed;
            
        transform.position += transform.forward * Input.GetAxis("Vertical") * updatedSpeed * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * updatedSpeed * Time.deltaTime;
    }
}
