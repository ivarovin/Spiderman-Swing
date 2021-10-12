using System;
using UnityEngine;

namespace Swing.Cobweb
{
    public abstract class AbstractCobwebGetter : MonoBehaviour, CobwebTargetGetter
    {
        public Action<Vector3> onCobwebFound;
        public Action onNoCobwebsFound;

        public abstract void FindAvailableCobweb(CobwebTarget[] _cobwebs);
    }
}