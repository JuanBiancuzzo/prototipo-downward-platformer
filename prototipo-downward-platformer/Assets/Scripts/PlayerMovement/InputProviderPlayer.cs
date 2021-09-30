using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class InputProviderPlayer : AInputProvider
{
    public List<AInputMiddleware> cadena = new List<AInputMiddleware>();

    public override void AgregarInputMiddleware(AInputMiddleware inputMiddleware)
    {
        cadena.Add(inputMiddleware);
    }

    public override void SacarInputMiddleware(AInputMiddleware inputMiddleware)
    {
        cadena.Remove(inputMiddleware);
    }

    // public event Action OnJump; // despues agregar

    public override InputState GetState() 
    {
        InputState inputState = new InputState();

        foreach (AInputMiddleware inputMiddleware in cadena)
            inputState = inputMiddleware.Procesar(inputState);

        return inputState;
    }
}
