using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public struct InputState
{
    public Vector2 direccion;
    public bool agachado;
}

public interface IInputProvider
{
    // public event Action OnJump;

    public void AgregarInputMiddleware(IInputMiddleware inputMiddleware);

    public void SacarInputMiddleware(IInputMiddleware inputMiddleware);

    public InputState GetState();
}
