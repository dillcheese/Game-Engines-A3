using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    public Text myText;
    public bool texting = false;
    public GameObject bonusGet;

    private Bonus bonusT;

    private void Start()
    {
        bonusT = bonusGet.GetComponent<Bonus>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (texting && bonusT.gotBonus)
        {
            myText.text = " YOU WON \n BONUS OBTAINED";
            // Debug.Log("WINNIG" + bonusT.gotBonus);
        }
        else if (texting)
        {
            myText.text = " YOU WON";
            //Debug.Log("No bonus");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Movement win = other.gameObject.GetComponent<Movement>();
        if (win)
        {
            texting = true;
            //Debug.Log("WINNIG");
        }
    }
}