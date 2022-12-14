using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    // 2) Instanzvariable nutzen
    int incrementedByOne = 0;

    // 3) Der Wert, der dazugezählt wird, ist bei der Deklaration noch nicht bekannt
    // z.B.: Random oder User Input
    int incrementedByX = 0;

    // 4) Copy by Value
    int decrementedByOne = 10;

    // 5) Return
    int differenzedValue = 20;

    private void Start()
    {
        // 1) Verwende Start Methode
        Debug.Log("Hallo Methoden!");

        // at 2)
        Debug.Log("before startValue: " + incrementedByOne);
        IncrementByOne();
        Debug.Log("after starValue: " + incrementedByOne);

        // at 3)
        Debug.Log("before startValue3: " + incrementedByX);
        IncrementByX(Random.Range(1,10));
        Debug.Log("after starValue3: " + incrementedByX);

        // at 4)
        Debug.Log("before starValue: " + decrementedByOne);
        OutputDecrementedByOne(decrementedByOne);
        Debug.Log("after starValue: " + decrementedByOne);

        // at 5)
        Debug.Log("before starValue: " + differenzedValue);
        differenzedValue = GetDifferenz(differenzedValue, 2);
        Debug.Log("after starValue: " + differenzedValue);
    }

    // 5)
    int GetDifferenz(int start, int valToSub)
    {
        return start - valToSub;
    }

    // 4)
    void OutputDecrementedByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    // 3)
    void IncrementByX(int valToAdd)
    {
        incrementedByX += valToAdd;
    }

    // 2)
    void IncrementByOne()
    {
        incrementedByOne++;
    }
}