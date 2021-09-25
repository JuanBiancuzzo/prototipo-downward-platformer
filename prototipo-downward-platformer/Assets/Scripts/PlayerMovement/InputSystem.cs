using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : IInputMiddleware
{
    // public CharacterController controlador;

    // public InputSystem(CharacterController _controlador)
    // {
    //     controlador = _controlador;
    // }

    public InputState Procesar(InputState inputState)
    {
        inputState.direccion = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // inputState.cayendo = !controlador.isGrounded;
        // inputState.saltar = Input.GetButton("Jump");

        return inputState;
    }
}
