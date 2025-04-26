using UnityEngine;
using TMPro;
public class sheeplog : MonoBehaviour

{
    public string sheepy = "Da SHEEPeEs eXpLOde!!!!1!";
    public TextMeshProUGUI sheepyText;

    private void OnTriggerEnter(Collider other)
    {
    if(other.transform.tag == "sheepy")
    {
        sheepyText.text =  sheepy;
    }
    
    }
    private void OnTriggerExit(Collider other)
    {
    if(other.transform.tag == "sheepy")
    {
        Destroy(sheepyText);
    }
    }
}