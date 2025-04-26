using UnityEngine;
using TMPro;
public class mono : MonoBehaviour
{
    //public string intro = "story";

    public TextMeshProUGUI monoText;

    private void OnTriggerEnter(Collider other)
    {
    if(other.transform.tag == "tent")
    {
        monoText.text = "story";
        //Debug.Log(gem);
    }
    }
    /*private void OntriggerExit(Collider other);
    {
        Destroy(monoText);
    }
    */
}
