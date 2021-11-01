using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Material mat;
    private Color rand;
    private Color rand2;

    // Start is called before the first frame update
    private void Start()
    {
        mat = GetComponent<Renderer>().material;

        rand = Random.ColorHSV();
        rand2 = Random.ColorHSV();
    }

    // Update is called once per frame
    private void Update()
    {
        mat.color = Color.Lerp(rand, rand2, Mathf.PingPong(Time.time, 2f)); //Color.red;
    }
}