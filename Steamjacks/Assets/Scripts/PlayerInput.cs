using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerInput : NetworkBehaviour
{
    [Header("References:")]
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private GrapplingGun _grapplingGun;
    private float _movement;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            _grapplingGun.SetGrapplePoint();
        else if (Input.GetKey(KeyCode.Mouse0))
            _grapplingGun.Holding();
        else if (Input.GetKeyUp(KeyCode.Mouse0))
            _grapplingGun.Release();
        else
            _grapplingGun.StartRotation();

        _movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        if (!IsOwner) return;
        _playerController.Move(_movement);
    }
}
