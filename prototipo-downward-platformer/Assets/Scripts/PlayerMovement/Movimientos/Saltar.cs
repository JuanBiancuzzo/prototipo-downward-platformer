using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltar : AMovimiento
{
    public float velocidad_salto = 4f;

    public override InputState Mover(InputState inputState, Rigidbody2D rigidbody)
    {
        // if (inputState.saltar)
            // inputState.cayendo = false;

        return inputState;
    }
}
