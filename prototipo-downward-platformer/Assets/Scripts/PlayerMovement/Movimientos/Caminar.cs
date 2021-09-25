using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caminar : IMovimiento
{
    public float velocidad = 5f;

    public void Mover(InputState inputState, CharacterController controlador)
    {
        Vector3 movimiento = new Vector3(inputState.direccion.x * Time.deltaTime * velocidad, 0f, 0f);

        controlador.Move(movimiento);
    }
}

