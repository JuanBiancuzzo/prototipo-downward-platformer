using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public IInputProvider inputProvider = new InputProviderPlayer();

    // Start is called before the first frame update
    void Start()
    {
        inputProvider.AgregarInputMiddleware(new InputSystem());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
