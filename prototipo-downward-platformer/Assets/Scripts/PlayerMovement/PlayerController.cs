using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AInputProvider inputProvider = new InputProviderPlayer();
    public List<AMovimiento> movimientos = new List<AMovimiento>();
    public Rigidbody2D cuerpo;


    void Start()
    {
        inputProvider.AgregarInputMiddleware(new InputSystem());
        movimientos.Add(new Caminar());
        movimientos.Add(new Saltar());
    }

    void Update()
    {
        InputState inputState = inputProvider.GetState();
        foreach (AMovimiento movimiento in movimientos)
            inputState = movimiento.Mover(inputState, cuerpo);
    }
    
}
