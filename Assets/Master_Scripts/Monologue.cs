using System Collections;
using System Collections Generic;
using UnityEngine;
using TMPro

public class Monologue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartDialogue()
    {
        index = 0;
    }
    IEnumerator TypeLine() 
    {
        // Type each character 1 by 1
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c; 
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
// Dialogue one, after pressing mushroomGuy's tent.

// public String monologue = "I can't believe no one is hiring me after getting my forestry degree, people only want lawns these days. Oh well, I'm back in the forest where I belong... Maybe I can find some stuff to pay back my debt."

// How do I put this in a box?