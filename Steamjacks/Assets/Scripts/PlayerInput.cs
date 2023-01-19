using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerInput : NetworkBehaviour
{
    [SerializeField] private PlayerController _playerController;
    private float _movement;

    private void Update()
    {
        _movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        if (!IsOwner) return;
        _playerController.Move(_movement);
    }
}
