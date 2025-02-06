using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayInputController : MonoBehaviour
{

    public bool isForward;
    public bool isBackward;
    public bool turnRight;
    public bool turnLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
    }
    void GetPlayerInput()
    {

        isForward = Keyboard.current.wKey.isPressed;
        isBackward = Keyboard.current.sKey.isPressed;
        turnRight = Keyboard.current.aKey.isPressed;
        turnLeft = Keyboard.current.dKey.isPressed;
    }
}
