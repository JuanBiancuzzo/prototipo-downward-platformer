using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caminar : AMovimiento
{
    public float velocidad = 15f;
    
    private float m_MovementSmoothing = .05f;
    private Vector3 m_Velocity = Vector3.zero;

    public override InputState Mover(InputState inputState, Rigidbody2D rigidbody)
    {
        
        Vector3 targetVelocity = new Vector2(inputState.direccion.x * velocidad, rigidbody.velocity.y);
		rigidbody.velocity = Vector3.SmoothDamp(rigidbody.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);

        return inputState;
    }
}
