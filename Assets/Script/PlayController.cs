using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    public float speed = 20;
    public float turnspeed = 20;
    public float horizontal_input;
    public float vertical_input;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        horizontal_input = Input.GetAxis("Horizontal");
        vertical_input = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical_input);
        // transform.Translate(Vector3.right * Time.deltaTime * turnspeed * horizontal_input);
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontal_input);
    }
}
