using UnityEngine;

namespace Swing.Cobweb
{
    public class CobwebTargetLine : MonoBehaviour, CobwebTarget
    {
        [SerializeField] private Transform pointA = null;
        [SerializeField] private Transform pointB = null;

        private Transform characterCamera;

        private void Start()
        {
            characterCamera = Camera.main.transform;
        }

        public Vector3 GetPosition()
        {
            var angle = Vector3.SignedAngle(characterCamera.forward,
                                            pointA.position - characterCamera.position,
                                            characterCamera.up);

            return Vector3.Lerp(pointA.position, pointB.position, angle);
        }
    }
}