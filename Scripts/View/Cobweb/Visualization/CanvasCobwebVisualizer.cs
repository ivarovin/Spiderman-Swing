using UnityEngine;

public class CanvasCobwebVisualizer : AbstractCobwebVisualizer
{
    [SerializeField] private Transform pointer = null;

    private Camera characterCamera;

    private void Start()
    {
        characterCamera = Camera.main;
    }

    public override void Visualize(Vector3 _point)
    {
        pointer.gameObject.SetActive(gameObject);
        pointer.position = characterCamera.WorldToScreenPoint(_point);
    }

    public override void Hide()
    {
        pointer.gameObject.SetActive(false);
    }
}