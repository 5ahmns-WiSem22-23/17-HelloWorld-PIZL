using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{
    [SerializeField] int[,] myArray = new int[3, 5]; // first dimension = rows, second dimension = columns

    private void Start()
    {
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Debug.Log("i ist " + i + ", j ist " + j);
            }
        }
    }
}