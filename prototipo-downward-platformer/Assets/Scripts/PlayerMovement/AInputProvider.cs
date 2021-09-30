using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public struct InputState
{
    public Vector2 direccion;
    // public bool cayendo;
    // public bool saltar;
}

public abstract class AInputProvider : MonoBehaviour
{
    // public event Action OnJump;

    public abstract void AgregarInputMiddleware(AInputMiddleware inputMiddleware);

    public abstract void SacarInputMiddleware(AInputMiddleware inputMiddleware);

    public abstract InputState GetState();
}
