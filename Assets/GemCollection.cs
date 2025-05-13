using UnityEngine;
using TMPro;
public class GemCollection : MonoBehaviour
{
    private int gem = 0;

    public TextMeshProUGUI GemText;

// public TextMeshProUGUI EndText;

    private void OnTriggerEnter(Collider other)
    {
    if(other.transform.tag == "stone")
    {
        gem += other.GetComponent<gemValue>().Value;
        GemText.text = "Gems needed: " + gem.ToString() + "/10";
        Debug.Log(gem);
        Destroy(other.gameObject);
    }  
}

 /*
    private void gamerEnd(Collider other)
    {
    if(gem >= 10) 
    {
        EndText.text = "Ewe're Winner!!!!1!!";
    }


    } 
*/
}
