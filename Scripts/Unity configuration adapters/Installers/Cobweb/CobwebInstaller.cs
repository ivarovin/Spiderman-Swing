using UnityEngine;
using Swing.Cobweb;

public class CobwebInstaller : MonoBehaviour
{
    [SerializeField] private CobwebFinderController cobwebController = null;

    [Space]
    [SerializeField] private AbstractCobwebDetector cobwebDetector = null;
    [SerializeField] private AbstractCobwebGetter cobwebGetter = null;

    private void Awake()
    {
        cobwebController.Configure(GetTargetFinder());
    }

    private CobwebTargetFinder GetTargetFinder()
    {
        return new CobwebTargetFinder(cobwebDetector, cobwebGetter);
    }
}