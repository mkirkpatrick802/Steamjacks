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
        //if(Input.GetKeyDown(KeyCode.Mouse0))
                //Fire
        //else if(Input.GetKey(KeyCode.Mouse0))
                //Hold
        //else if(Input.GetKeyUp(KeyCode.Mouse0))
                //Release
        //else
                //Rotate Gun

        _movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        if (!IsOwner) return;
        _playerController.Move(_movement);
    }
}
