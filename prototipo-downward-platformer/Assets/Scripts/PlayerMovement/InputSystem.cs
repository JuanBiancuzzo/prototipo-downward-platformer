using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : IInputMiddleware
{
    public InputState Procesar(InputState inputState)
    {
        inputState.direccion = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        inputState.agachado = Input.GetKey(KeyCode.LeftControl);
        inputState.saltar = Input.GetButtonDown("Jump");

        return inputState;
    }
}
