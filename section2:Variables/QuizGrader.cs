using UnityEngine;

public class Testa : MonoBehaviour
{
    int[] testScores; // Declare the array at the class level
    int averageScore; // Declare a variable to hold the final answer

    // Function to generate a specified number of random test scores
    void GenerateTests(int numberOfScores)
    {
        // Initialize the testScores array with the specified number of elements.
        testScores = new int[numberOfScores];
        for (int i = 0; i < numberOfScores; i++)
        {
            testScores[i] = Random.Range(1, 101); // Generate random scores between 1 and 100
        }

        // Debug log to check the contents of the class-level array
        for (int i = 0; i < numberOfScores; i++)
        {
            Debug.Log("Test Score " + (i + 1) + ": " + testScores[i]);
        }
    }

    // No parameters because this class-level function relies on the class-level array
    void CalculateAverage()
    {
        if (testScores == null)
        {
            Debug.LogError("Test scores array is null.");
            return;
        }

        // Calculate the sum of testScores array
        int numberOfTests = testScores.Length;
        int sum = 0;
        for (int i = 0; i < numberOfTests; i++)
        {
            sum += testScores[i];
        }

        float average = (float)sum / numberOfTests; // Calculate the average as a float
        averageScore = Mathf.RoundToInt(average); // Round the average to the nearest integer
        Debug.Log("Average Test Score: " + averageScore);
    }

    void Start()
    {
        Debug.Log("Running Console Program");

        // Call the GenerateTests function with the number of scores you want (e.g., 5).
        GenerateTests(5);

        // Call the CalculateAverage function to calculate and print the average.
        CalculateAverage();
    }
}

