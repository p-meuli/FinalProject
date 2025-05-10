using UnityEngine;
using TMPro;
public class GemCollection : MonoBehaviour
{
    private int gem = 0;

    public TextMeshProUGUI GemText;

    public TextMeshProUGUI EndText;

    private void OnTriggerEnter(Collider other)
    {
    if(other.transform.tag == "stone")
    {
        gem += other.GetComponent<gemValue>().Value;
        GemText.text = "Gems needed: " + gem.ToString() + "/70,000";
        Debug.Log(gem);
        Destroy(other.gameObject);
    }  
    if(gem >= 70000) 
        {
        EndText.text = "Ewe're Winner!!!!1!!";
        }
}

} 
 
