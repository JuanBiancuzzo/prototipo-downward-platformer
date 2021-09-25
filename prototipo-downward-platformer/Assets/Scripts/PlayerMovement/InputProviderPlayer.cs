using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class InputProviderPlayer : IInputProvider
{
    public List<IInputMiddleware> cadena = new List<IInputMiddleware>();

    public void AgregarInputMiddleware(IInputMiddleware inputMiddleware)
    {
        cadena.Add(inputMiddleware);
    }

    public void SacarInputMiddleware(IInputMiddleware inputMiddleware)
    {
        cadena.Remove(inputMiddleware);
    }

    // public event Action OnJump; // despues agregar

    public InputState GetState() 
    {
        InputState inputState = new InputState();

        foreach (IInputMiddleware inputMiddleware in cadena)
            inputState = inputMiddleware.Procesar(inputState);

        return inputState;
    }
}
