using UnityEngine;
using TMPro;
public class GemCollection : MonoBehaviour
{
    private int gem = 0;

    public TextMeshProUGUI GemText;

    private void OnTriggerEnter(Collider other)
    {
    if(other.transform.tag == "stone")
    {
        gem++;
        GemText.text = "Gems needed: " + gem.ToString() + "/10";
        Debug.Log(gem);
        Destroy(other.gameObject);
    }
    }
}
