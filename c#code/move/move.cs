using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;


public class move : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    bool isForward;
    bool isBackward;
    bool turnRight;
    bool turnLeft;
    // Start is called before the first frame update

    void Start()
    {
        speed = 5f;
        turnSpeed = 15;





    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
        // Debug.Log( moveCube());
        moveCube();

    }

    void GetPlayerInput()
    {

        isForward = Keyboard.current.wKey.isPressed;
        isBackward = Keyboard.current.sKey.isPressed;
        turnRight = Keyboard.current.aKey.isPressed;
        turnLeft = Keyboard.current.dKey.isPressed;
    }
    string moveCube()
    {

        if (isForward)
        {
            transform.Translate(new Vector3(0, 0, 1) * (speed * Time.deltaTime));
        }
        else if (isBackward)
        {
            transform.Translate(new Vector3(0, 0, -1) * (speed * Time.deltaTime));
        }
        else if (turnRight)
        {
            transform.Rotate(new Vector3(0, 1, 0), -60 * (turnSpeed * Time.deltaTime));
        }
        else if (turnLeft)
        {
            transform.Rotate(new Vector3(0, 1, 0), 60 * (turnSpeed * Time.deltaTime));
        }
        else
        {
            return "玩家没动";
            // Debug.Log("not moveing");
        }
        return "玩家移动了";
    }

}

