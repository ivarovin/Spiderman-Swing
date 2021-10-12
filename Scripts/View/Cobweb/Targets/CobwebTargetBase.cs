using UnityEngine;

namespace Swing.Cobweb
{
    public class CobwebTargetBase : MonoBehaviour, CobwebTarget
    {
        public Vector3 GetPosition()
        {
            return transform.position;
        }
    }
}