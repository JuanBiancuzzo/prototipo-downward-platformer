using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AInputMiddleware : MonoBehaviour
{
    public abstract InputState Procesar(InputState inputState);
}

