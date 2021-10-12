using UnityEngine;

public abstract class AbstractCobwebVisualizer : MonoBehaviour
{
    public abstract void Visualize(Vector3 _point);
    public abstract void Hide();
}