using UnityEngine;

namespace Swing.Cobweb
{
    public class CobwebTargetMediator : MonoBehaviour
    {
        [SerializeField] private AbstractCobwebGetter cobwebGetter = null;
        [SerializeField] private AbstractCobwebVisualizer cobwebVisualizer = null;

        private void Start()
        {
            cobwebGetter.onCobwebFound += cobwebVisualizer.Visualize;
            cobwebGetter.onNoCobwebsFound += cobwebVisualizer.Hide;
        }
    }
}