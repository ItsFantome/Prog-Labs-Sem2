using UnityEngine;

public class Generic : MonoBehaviour
{
    private int[] intArray = { 4, 5, 6 };
    private float[] floatArray = { 4.4f, 5.5f, 6.6f };
    private string[] strArray = { "Aa", "Bb", "Cc" };

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            DisplayElements(intArray);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            DisplayElements(floatArray);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            DisplayElements(strArray);
        }
    }

    public void DisplayElements<Object>(Object[] arr)
    {
        foreach (Object item in arr)
        {
            print(item);
        }
    }
}