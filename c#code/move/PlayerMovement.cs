using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XInput;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 12;
    public PlayInputController inputController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveCube();
    }
    void moveCube()
    {

        if (inputController.isForward)
        {
            transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }
        else if (inputController.isBackward)
        {
            transform.Translate(Vector3.back * (speed * Time.deltaTime));
        }
        else if (inputController.turnRight)
        {
            transform.Rotate(Vector3.up, -turnSpeed * (turnSpeed * Time.deltaTime));
        }
        else if (inputController.turnLeft)
        {
            transform.Rotate(Vector3.up, turnSpeed * (turnSpeed * Time.deltaTime));
        }
        else
        {
            return;
            // Debug.Log("not moveing");
        }
        return ;
    }
}
