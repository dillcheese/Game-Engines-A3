using System.Runtime.InteropServices;
using UnityEngine;

public class UsePlugin : MonoBehaviour
{
    [DllImport("NativePlugin")]
    private static extern int PrintANumber();

    [DllImport("NativePlugin")]
    private static extern int AddTwoIntegers(int i1, int i2);

    [DllImport("NativePlugin")]
    private static extern float AddTwoFloats(float f1, float f2);

    // Start is called before the first frame update
    private void Start()
    {
        //Debug.Log(PrintANumber());
        //Debug.Log(AddTwoIntegers(3, 9));
        //Debug.Log(AddTwoFloats(2.9f, 7.5f));
    }
}