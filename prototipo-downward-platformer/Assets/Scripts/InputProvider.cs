using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "InputProvider", menuName = "ScriptableObjects/InputProvider")]
public class InputProvider : ScriptableObject, IInputProvider
{
    [SerializeField]public List<IInputMiddleware> cadena;

    // public event Action OnJump;

    public InputState GetState() 
    {
        InputState inputState = new InputState();

        foreach (IInputMiddleware inputMiddleware in cadena)
            inputState = inputMiddleware.Procesar(inputState);

        return inputState;
    }
}
