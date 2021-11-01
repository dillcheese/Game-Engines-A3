using System.Runtime.InteropServices;
using UnityEngine;

public class UseDLLQuiz : MonoBehaviour
{
    [DllImport("DLLQuiz")]
    private static extern int RandNum();


    // Start is called before the first frame update
    private void Start()
    {
        Transform d = GetComponent<Transform>();
        float rand = RandNum() + d.position.x;
        Vector3 newpos = new Vector3(rand, d.position.y, d.position.z);
        d.position = newpos;


        //Vector3 = Vector3D
        // Debug.Log(GetID());
       // Debug.Log(GetPosition());
    }
}
