using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
        }
    }
}
