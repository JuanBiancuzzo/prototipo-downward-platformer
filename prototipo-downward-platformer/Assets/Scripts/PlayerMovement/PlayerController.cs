using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public IInputProvider inputProvider = new InputProviderPlayer();

    void Start()
    {
        inputProvider.AgregarInputMiddleware(new InputSystem());
    }

    
}
