using UnityEngine;
using UnityEngine.InputSystem;

namespace DefaultNamespace
{
    public class MouseController : MonoBehaviour
    {
        private Vector3 mousePosition;
        public BoxCollider targetObject;
        private float maxX = 17, maxY = 10, ratio = 10;
        
        // Use this for initialization
        void Start()
        {
        }
        
        void Update()
        {
            float x = Mouse.current.position.x.ReadValue()/ratio;
            float y = Mouse.current.position.y.ReadValue()/ratio;
            if (x > maxX)
            {
                x = maxX;   
            }
            else if (x < -maxX)
            {
                x = -maxX;
            }
            if (y > maxY)
            {
                y = maxY;
            }else if (y < -maxY)
            {
                y = -maxY;   
            }
            mousePosition = new Vector3(x,y);
            targetObject.transform.position = mousePosition;
        }
    }
}