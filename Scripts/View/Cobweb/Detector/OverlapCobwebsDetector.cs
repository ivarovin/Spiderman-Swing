using UnityEngine;

namespace Swing.Cobweb
{
    public class OverlapCobwebsDetector : AbstractCobwebDetector
    {
        [SerializeField] private LayerMask cobwebsTargetLayer = 0;
        [SerializeField] private float detectionRadius = 10;
        [SerializeField] private byte maxDetections = 5;

        private Collider[] cobwebsCollider;
        private CobwebTarget[] cobwebTargets;

        private void Start()
        {
            cobwebsCollider = new Collider[maxDetections];
        }

        public override CobwebTarget[] DetectCobwebTargets()
        {
            var detectedTargets = Physics.OverlapSphereNonAlloc(transform.position,
                                                                detectionRadius,
                                                                cobwebsCollider,
                                                                cobwebsTargetLayer);

            cobwebTargets = new CobwebTarget[detectedTargets];

            for (int i = 0; i < detectedTargets; i++)
            {
                cobwebTargets[i] = cobwebsCollider[i].GetComponent<CobwebTarget>();
            }

            return cobwebTargets;
        }
    }
}