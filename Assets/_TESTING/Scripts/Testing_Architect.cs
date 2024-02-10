using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        string[] lines = new string[5]
        {
            "1 This is a random line of dialogue.",
            "2 I want to say something come over here.",
            "3 The word is a crazy place sometimes.",
            "4 Don't lose hope, things will get better!",
            "5 It's a bird? It's a plane? No! - It's Super Sheltie!"
        };
        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.typewriter;
        }

        // Update is called once per frame
         void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
               architect.Build(lines[Random.Range(0,lines.Length)]);
            }
            else if(Input.GetKeyDown(KeyCode.A))
            {
                architect.Append(lines[Random.Range(0,lines.Length)]);
            }
        }
    }
}