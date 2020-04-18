using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using static UnityEngine.InputSystem.InputAction;

namespace DapperDino.BuildingBlocks
{
    public class TurretMovement : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 5f;
        [SerializeField] private Vector2 limits = new Vector2(-4f, 4f);

        private float previousInput;

        private bool isX;
        private bool isY;
        private bool isZ;

        private void Update() => Move();

        public void MoveInput(CallbackContext ctx)
        {
            if (ctx.control is KeyControl) {
                var key = (KeyControl)ctx.control;
                isX = isY = isZ = false;
                switch (key.keyCode) {
                    case Key.W:
                    case Key.S:
                        isY = true;
                        break;
                    default: isX = true; break;
                }
            }
            
            if (ctx.performed)
            {
                previousInput = ctx.ReadValue<float>();
                return;
            }

            if (ctx.canceled)
            {
                previousInput = 0f;
            }
        }

        private void Move()
        {
            float movement = previousInput * movementSpeed * Time.deltaTime;

            
            if (isY) {
                float newYValue = Mathf.Clamp(transform.position.y + movement, limits.x, limits.y);
                transform.position = new Vector3(transform.position.x, newYValue, transform.position.z);
            }
            else { //isX
                float newXValue = Mathf.Clamp(transform.position.x + movement, limits.x, limits.y);
                transform.position = new Vector3(newXValue, transform.position.y, transform.position.z);
            }
        }
    }
}
