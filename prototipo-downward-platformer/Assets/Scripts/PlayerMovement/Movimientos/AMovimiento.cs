using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AMovimiento : MonoBehaviour
{
    public abstract InputState Mover(InputState inputState, Rigidbody2D rigidbody);
}
