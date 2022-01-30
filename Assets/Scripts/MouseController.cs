using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DefaultNamespace
{
    public class MouseController : MonoBehaviour
    {
        private Vector3 _mousePosition;
        public float mousePositionX;
        public float mousePositionY;
        public Transform targetObject;
        public float MAXX = 1f, MAXY = 0.5f, RATIO = 100f;
        public float zcoord = -2;
        public Painting paintBrush;

        // Use this for initialization
        void Start()
        {
            _mousePosition = new Vector3(0, 0, zcoord);
            MAXX = GameManager.singleton.levelBounds.localScale.x / 2;
            MAXY = GameManager.singleton.levelBounds.localScale.y / 2;
            RATIO = RATIO/Math.Max(MAXX, MAXY);
        }

        void Update()
        {
            mousePositionX = (Mouse.current.delta.x.ReadValue() / RATIO) + _mousePosition.x;
            mousePositionY = (Mouse.current.delta.y.ReadValue() / RATIO) + _mousePosition.y;
            
            
            
            if (mousePositionX > MAXX)
            {
                mousePositionX = MAXX;
            }
            else if (mousePositionX < -MAXX)
            {
                mousePositionX = -MAXX;
            }

            if (mousePositionY > MAXY)
            {
                mousePositionY = MAXY;
            }
            else if (mousePositionY < -MAXY)
            {
                mousePositionY = -MAXY;
            }
            
            _mousePosition = new Vector3(mousePositionX, mousePositionY, zcoord);
            targetObject.transform.position = _mousePosition;

            /*
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
            */
        }
    }
}