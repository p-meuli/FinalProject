using UnityEngine;
using TMPro;

public class intro : MonoBehaviour
{
    //public string intro = "story";

    public TextMeshProUGUI monoText;

    private void OnTriggerEnter(Collider other)
    {
    if(other.transform.tag == "tent")
    {
        monoText.text = "I can't believe no one is hiring me after getting my forestry degree, people only want lawns these days. Oh well, I'm back in the forest where I belong... Maybe I can find some stuff to pay back my debt.";
        //Debug.Log(gem);
    }
    
    }
    private void OnTriggerExit(Collider other)
    {
    if(other.transform.tag == "tent")
    
    {
        Destroy(monoText);
    }
    }
}
