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

        [SerializeField] private Key XNegative = Key.A;
        [SerializeField] private Key XPositive = Key.D;

        [SerializeField] private Key YNegative = Key.S;
        [SerializeField] private Key YPositive = Key.W;

        [SerializeField] private Key ZNegative = Key.R;
        [SerializeField] private Key ZPositive = Key.Q;

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
                if (key.keyCode == YNegative || key.keyCode == YPositive) isY = true;
                else if (key.keyCode == ZNegative || key.keyCode == ZPositive) isZ = true;
                else isX = true;
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
            else if (isZ)
            {
                float newZValue = Mathf.Clamp(transform.position.z + movement, limits.x, limits.y);
                transform.position = new Vector3(transform.position.x, transform.position.y, newZValue);
            }
            else { //isX
                float newXValue = Mathf.Clamp(transform.position.x + movement, limits.x, limits.y);
                transform.position = new Vector3(newXValue, transform.position.y, transform.position.z);
            }
        }
    }
}
