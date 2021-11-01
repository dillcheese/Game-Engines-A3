using System.Runtime.InteropServices;
using UnityEngine;

public class NativePlugin : MonoBehaviour
{
    [DllImport("NativePlugin")]
    private static extern int PrintANumber();

    [DllImport("NativePlugin")]
    private static extern int SubTwoIntegers(int i1, int i2);

    [DllImport("NativePlugin")]
    private static extern int MultiplyTwoIntegers(int i1, int i2);

    [DllImport("NativePlugin")]
    private static extern int  DivTwoIntegers(int i1, int i2);

    [DllImport("NativePlugin")]
    private static extern void SortArray();

    // Start is called before the first frame update
    private void Start()
    {
        //Debug.Log(PrintANumber());
        //Debug.Log(SubTwoIntegers(3, 9));
        //Debug.Log(MultiplyTwoIntegers(9, 7));
        //Debug.Log(DivTwoIntegers(8, 2));

    }
}
