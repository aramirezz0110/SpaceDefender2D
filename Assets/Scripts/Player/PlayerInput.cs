using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender.Player
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private PlayerController playerController;

        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";
        private void Update()=> GetPlayerInputs();
        private void GetPlayerInputs()
        {
            if(!playerController) return;

            playerController.HorizontalInput = Input.GetAxis(Horizontal);
            playerController.VerticalInput = Input.GetAxis(Vertical);

            playerController.IsShooting = Input.GetKey(KeyCode.Space);
        }
    }
}