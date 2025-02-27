using UnityEngine;

namespace Sanktuary.Sometimes
{
    public class RotationController : MonoBehaviour
    {
        [Header("Rotation Variables")]
        public bool aroundOwnAxis = true;
        public float rotationSpeed = 3f;
        public Transform centerObject = null;
        public Vector3 rotationDirection = new Vector3(0, 0, -1);

        void Start() {
            if (centerObject == null) {
                centerObject = transform;
            }
        }

        void Update() {
            if (aroundOwnAxis) {
                transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
            } else {
                transform.RotateAround(centerObject.position, rotationDirection, rotationSpeed * Time.deltaTime);
            }
        }
    }
}
