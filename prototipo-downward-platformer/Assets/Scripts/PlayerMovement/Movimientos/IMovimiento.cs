using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovimiento
{
    public InputState Mover(InputState inputState, Rigidbody2D rigidbody);
}
