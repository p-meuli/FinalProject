using UnityEngine;
using TMPro;
public class forestinfo : MonoBehaviour

{
    public string info1 = "WELCOME TO THE CRYSTAL WOODS! \n";
    public string info2 = "This heritage site acts as a natural central bank and renewable reserve for the funkgus kingdom, \n";
    public string info3 = "At the behest of his royal highness King Flint Funkgus. Here, money literally grows on trees! (and around them too!) \n";
    public string info4 = " Unauthorized possession of gems is a captial offense against the crown, and is enforced by goblin mercinaries. \n";
    public string info5 = "-- Jerome Sporewell";
    
    public TextMeshProUGUI forestText;

    private void OnTriggerEnter(Collider other)
    {
    if(other.transform.tag == "forest-sign")
    {
        forestText.text =  info1 + info2 + info3 + info4 + info5;
    }
    
    }
    private void OnTriggerExit(Collider other)
    {
    if(other.transform.tag == "forest-sign")
    {
        Destroy(forestText);
    }
    }
}

