using UnityEngine;
using UnityEngine.InputSystem;

namespace DefaultNamespace
{
    public class MouseController : MonoBehaviour
    {
        private Vector3 _mousePosition;
        public Transform targetObject;
        private const float MAXX = 17, MAXY = 10, RATIO = 10;
        public Painting paintBrush;

        // Use this for initialization
        void Start()
        {
        }

        void Update()
        {
            var x = Mouse.current.position.x.ReadValue() / RATIO;
            var y = Mouse.current.position.y.ReadValue() / RATIO;
            if (x > MAXX)
            {
                x = MAXX;
            }
            else if (x < -MAXX)
            {
                x = -MAXX;
            }

            if (y > MAXY)
            {
                y = MAXY;
            }
            else if (y < -MAXY)
            {
                y = -MAXY;
            }

            _mousePosition = new Vector3(x, y);
            targetObject.transform.position = _mousePosition;

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                if (paintBrush.isPainting)
                {
                    paintBrush.isPainting = false;
                }
                else
                {
                    paintBrush.isPainting = true;
                }
            }
        }
    }
}