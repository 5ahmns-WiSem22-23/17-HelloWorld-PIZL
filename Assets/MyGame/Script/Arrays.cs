using UnityEngine;

public class Arrays : MonoBehaviour
{
    string[,] array1;

    string[,] array2 = new string[3, 4]
    {
        { "A", "B", "C", "D" },
        { "E", "F", "G", "H" },
        { "I", "J", "K", "L" },
    };

    string[,] array3 = new string[3, 4];
    string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };
    int alphabetIndex = 0;

    private void Start()
    {
        array1 = new string[,] { { "A", "B", "C", "D" }, { "E", "F", "G", "H" }, { "I", "J", "K", "L" } };

        for (int i = 0; i < array3.GetLength(0); i++)
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
                string letter = alphabet[alphabetIndex];
                Debug.Log("row: " + i + ", column: " + j + ", letter: " + letter);
                array3[i, j] = letter;
                alphabetIndex++;
            }
        }
    }
}