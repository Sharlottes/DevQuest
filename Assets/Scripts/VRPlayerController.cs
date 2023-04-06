using Oculus.Interaction;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class VRPlayerController : MonoBehaviour
{
    [Header("Presets")]
    [SerializeField] private PlayerInput _playerInput;

    [Header("Settings")]
    [SerializeField][Range(1f, 10f)] private float moveSpeed = 1f;
    [SerializeField][Range(0f, 10f)] private float sensitivity = 0.8f;
    
    private float mouseX, mouseY;

    public void OnRotate(InputAction.CallbackContext context)
    {
        (float dx, float dy) = context.ReadValue<Vector2>();

        mouseX += dx * sensitivity;
        
        transform.rotation = Quaternion.Euler(new Vector3(0, mouseX, 0));

        mouseY += dy * sensitivity;
        mouseY = Mathf.Clamp(mouseY, -75f, 75f);
        _playerInput.camera.transform.localRotation = Quaternion.Euler(new Vector3(-mouseY, 0, 0));
    }

    private void Update()
    {
        (float x, float z) = _playerInput.actions["Move"].ReadValue<Vector2>();
        Vector3 movement = new(x, 0f, z);
        movement.Normalize();
        transform.Translate(moveSpeed * Time.deltaTime * movement);
    }
}
