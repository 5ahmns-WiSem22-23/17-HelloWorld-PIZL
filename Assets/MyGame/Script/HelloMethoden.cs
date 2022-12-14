using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    // 2) Instanzvariable nutzen
    int startValue2 = 0;

    // 3) Der Wert, der dazugezählt wird, ist bei der Deklaration noch nicht bekannt
    // z.B.: Random oder User Input
    int startValue3 = 0;

    // 4) Copy by Value
    int startValue4 = 10;

    // 5) Return
    int startValue5 = 20;

    private void Start()
    {
        // 1) Verwende Start Methode
        Debug.Log("Hallo Methoden!");

        // at 2)
        Debug.Log("before startValue: " + startValue2);
        IncrementByOne();
        Debug.Log("after starValue: " + startValue2);

        // at 3)
        Debug.Log("before startValue3: " + startValue3);
        IncrementByX(Random.Range(1,10));
        Debug.Log("after starValue3: " + startValue3);

        // at 4)
        Debug.Log("before starValue: " + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("after starValue: " + startValue4);

        // at 5)
        Debug.Log("before starValue: " + startValue5);
        startValue5 = DecrementByX(startValue5, 2);
        Debug.Log("after starValue: " + startValue5);
    }

    // 5)
    int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }

    // 4)
    void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    // 3)
    void IncrementByX(int valToAdd)
    {
        startValue3 += valToAdd;
    }

    // 2)
    void IncrementByOne()
    {
        startValue2++;
    }
}