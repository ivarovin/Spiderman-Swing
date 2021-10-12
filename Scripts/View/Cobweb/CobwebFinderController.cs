using UnityEngine;

namespace Swing.Cobweb
{
    public class CobwebFinderController : MonoBehaviour
    {
        private CobwebTargetFinder targetsFinder;

        private void Update()
        {
            targetsFinder.FindAvailableCobweb();
        }

        public void Configure(CobwebTargetFinder _targetFinder)
        {
            targetsFinder = _targetFinder;
        }
    }
}