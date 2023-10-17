using UnityEngine;

public class Testa : MonoBehaviour
{
    int[] testScores; // Declare the array at the class level.
    int AverageScore;

    // Function to generate random test scores
    void GenerateTests(int numberOfScores)
    {
        testScores = new int[numberOfScores]; // Assign the generated scores to the class-level array.

        for (int i = 0; i < numberOfScores; i++)
        {
            testScores[i] = Random.Range(1, 101); // Generate random score between 1 and 100
        }

        // Print the generated test scores to the console
        for (int i = 0; i < numberOfScores; i++)
        {
            Debug.Log("Test Score " + (i + 1) + ": " + testScores[i]);
        }
    }


    //No params because this class level function relies on the class level array
    void ReturnAverage()
    {   

        //Use generate tests to populate the array before attempting to return the average
        if (testScores == null)
        {
            Debug.LogError("Test scores array is not initialized. Call GenerateTests first.");
            return;
        }


        //---- Get SUM of testScores Array
        int numberOfTests = testScores.Length; // Get the number of tests from the array.
        int sum = 0;
        for (int i = 0; i < numberOfTests; i++)
        {
            sum += testScores[i];
        }
        //----


        float average = (float)sum / numberOfTests; // Calculate the average as a float 



        AverageScore = average;                         //Once calculated set the value of the class level variable to this 
        Debug.Log("Average Test Score: " + average);    //Print it 

    }

    void Start()
    {
        Debug.Log("Running Console Program");

        // Call the GenerateTests function with the number of scores you want (e.g., 5).
        GenerateTests(5);

        // Call the ReturnAverage function to calculate and print the average.
        ReturnAverage();
    }
}

