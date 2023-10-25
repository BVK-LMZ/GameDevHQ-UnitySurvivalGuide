using UnityEngine;

public class CubeColorChanger : MonoBehaviour
{
    public enum CubeColor
    {
        Blue = 1,
        Green = 2,
        Red = 3,
        Orange = 4
    }

    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private CubeColor color;

    private Renderer cubeRenderer;
    private Material cubeMaterial;

    public CubeColor Color
    {
        get { return color; }
        set
        {
            color = value;
            // Ensure the cube's color is updated when the property changes.
            UpdateCubeColor();
        }
    }

    private void Start()
    {
        if (cube == null)
        {
            Debug.LogError("Cube reference is not set.");
        }
        else
        {
            cubeRenderer = cube.GetComponent<Renderer>();
            cubeMaterial = cubeRenderer.material;
        }
    }

    private void Update()
    {
        // Check the _colorVal and change the cube's color accordingly
        UpdateCubeColor();
    }

    private void UpdateCubeColor()
    {
        if (cubeMaterial != null)
        {
            switch (color)
            {
                case CubeColor.Blue:
                    cubeMaterial.color = Color.blue;
                    break;
                case CubeColor.Green:
                    cubeMaterial.color = Color.green;
                    break;
                case CubeColor.Red:
                    cubeMaterial.color = Color.red;
                    break;
                case CubeColor.Orange:
                    cubeMaterial.color = new Color(1.0f, 0.5f, 0.0f); // Orange
                    break;
                default:
                    // Handle other cases or provide a default color
                    break;
            }
        }
    }
}
