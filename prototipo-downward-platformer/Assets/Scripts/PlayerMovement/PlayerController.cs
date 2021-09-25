using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public IInputProvider inputProvider = new InputProviderPlayer();
    public List<IMovimiento> movimientos = new List<IMovimiento>();
    public CharacterController controlador;

    void Start()
    {
        inputProvider.AgregarInputMiddleware(new InputSystem());
        movimientos.Add(new Caminar());
        // movimientos.Add(new Saltar());
    }

    void Update()
    {
        InputState inputState = inputProvider.GetState();
        foreach (IMovimiento movimiento in movimientos)
            movimiento.Mover(inputState, controlador);
    }
    
}
