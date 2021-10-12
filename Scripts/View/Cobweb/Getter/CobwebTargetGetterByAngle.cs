using UnityEngine;

namespace Swing.Cobweb
{
    public class CobwebTargetGetterByAngle : AbstractCobwebGetter
    {
        [SerializeField] private Transform detectorTransform = null;
        [SerializeField] private float maxAngle = 60;

        public override void FindAvailableCobweb(CobwebTarget[] _cobwebs)
        {
            Vector3 nearestCobweb = Vector3.zero;
            float nearestAngle = 360;

            float currentAngle;

            for (int i = 0; i < _cobwebs.Length; i++)
            {
                currentAngle = Vector3.Angle(detectorTransform.forward,
                                             _cobwebs[i].GetPosition() - detectorTransform.position);

                if (currentAngle < maxAngle && currentAngle < nearestAngle)
                {
                    nearestCobweb = _cobwebs[i].GetPosition();
                    nearestAngle = currentAngle;
                }
            }

            if (nearestCobweb == Vector3.zero)
            {
                onNoCobwebsFound?.Invoke();
            }
            else onCobwebFound?.Invoke(nearestCobweb);
        }
    }
}