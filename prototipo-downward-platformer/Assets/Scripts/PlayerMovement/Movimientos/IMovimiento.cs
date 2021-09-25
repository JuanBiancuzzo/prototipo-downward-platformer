using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovimiento
{
    public void Mover(InputState inputState, CharacterController controlador);
}
