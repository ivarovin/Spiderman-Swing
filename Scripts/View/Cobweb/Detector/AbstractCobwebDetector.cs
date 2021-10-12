using UnityEngine;

namespace Swing.Cobweb
{
    public abstract class AbstractCobwebDetector : MonoBehaviour, CobwebTargetsDetector
    {
        public abstract CobwebTarget[] DetectCobwebTargets();
    }
}