using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    public Text myText;
    public bool texting = false;

    // Update is called once per frame
    private void Update()
    {
        if (texting)
        {
            myText.text = " YOU WON";
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Movement win = other.gameObject.GetComponent<Movement>();
        if (win)
        {
            texting = true;
            Debug.Log("WINNIG");
        }
    }
}