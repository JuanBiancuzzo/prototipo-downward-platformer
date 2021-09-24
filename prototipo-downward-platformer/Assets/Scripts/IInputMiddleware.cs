using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputMiddleware
{
    public InputState Procesar(InputState inputState);
}

