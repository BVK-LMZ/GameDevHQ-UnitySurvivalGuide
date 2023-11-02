
using UnityEngine;


/// <summary>
/// This script, 'CubeSpawnerWithColorChange,' is responsible for dynamically spawning a cube primitive at the origin (0, 0, 0) 
/// and enabling users to change its color with the press of the space key. 
/// 
/// It provides an interactive experience, allowing the cube's appearance to be altered by selecting a random color from a predefined array. 
/// The class manages both the cube creation and color-changing aspects,
/// offering a clear example of how to create and manipulate objects within the Unity environment.
/// </summary>


public class CoolCube : MonoBehaviour
{
    private GameObject currentCube; // Reference to the currently spawned cube
    private Color[] colors; // Array to store three colors
    private Color previousColor; // To track the previous color

    /// <summary>
    /// Start is called before the first frame update.
    /// Initializes the colors array and spawns a cube at the origin.
    /// </summary>
    private void Start()
    {
        // Initialize the colors array with desired colors
        colors = new Color[] { Color.red, Color.blue, Color.green };

        // Spawn a cube at position (0, 0, 0)
        SpawnCube(Vector3.zero);
    }

    /// <summary>
    /// Spawns a cube primitive at the specified position.
    /// Sets the initial color for the spawned cube.
    /// </summary>
    /// <param name="position">The position to spawn the cube.</param>
    private void SpawnCube(Vector3 position)
    {
        // Create a cube primitive and set its position
        currentCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        currentCube.transform.position = position;

        // Set the initial color for the spawned cube
        SetRandomColor();
    }

    /// <summary>
    /// Update is called once per frame.
    /// Checks for user input to change the cube's color when the space key is pressed.
    /// </summary>
    private void Update()
    {
        if (currentCube != null && Input.GetKeyDown(KeyCode.Space))
        {
            // Change the cube's color to a random color
            SetRandomColor();


            // Debug the cube's color information
        Debug.Log($"Cube color changed to: {currentCube.GetComponent<Renderer>().material.color}");
        }


    
    }

    /// <summary>
    /// Sets a random color for the cube.
    /// Ensures that the new color is different from the previous color.
    /// </summary>
    private void SetRandomColor()
    {
        Color randomColor;
        do
        {
            // Generate a random index within the range of the colors array
            int randomIndex = Random.Range(0, colors.Length);
            // Get the color at the random index
            randomColor = colors[randomIndex];
        }
        while (randomColor == previousColor); // Ensure the color is different from the previous color

        // Set the cube's color to the random color
        currentCube.GetComponent<Renderer>().material.color = randomColor;

        // Update the previousColor variable
        previousColor = randomColor;
    }
}
