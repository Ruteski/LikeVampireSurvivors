using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private float speed;

   private Rigidbody2D _rig;
   private Vector2 _movementDirection;

   private void Start()
   {
      _rig = GetComponent<Rigidbody2D>();
   }

   private void FixedUpdate()
   {
      _rig.linearVelocity = _movementDirection.normalized * speed; 
   }

   private void OnMove(InputValue value)
   {
      _movementDirection = value.Get<Vector2>();
   }
}
