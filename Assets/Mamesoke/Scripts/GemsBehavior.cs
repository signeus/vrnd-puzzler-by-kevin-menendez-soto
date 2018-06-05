using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsBehavior : MonoBehaviour {

    public string type = "";

    //List<Material> materials = new List<Material>();
    public Material[] materials;

    Material myMaterial;
    GameObject child;
    public int theChoosenOne = 0;

    Transform theChild;

	// Use this for initialization
	void Start () {

        theChild = GetComponent<Transform>().GetChild(0);
        theChoosenOne = Random.Range(0, materials.Length);

        theChild.GetComponent<MeshRenderer>().material = materials[theChoosenOne];

        // Determine position with relation to the material
        if (theChoosenOne == 0)
        {
            type = "yellow";
        }
        else if (theChoosenOne == 1)
        {
            type = "red";
        }
        else if (theChoosenOne == 2)
        {
            type = "purple";
        }
        else if (theChoosenOne == 4)
        {
            type = "blue";
        }
	}

    private string AssignName(int selected){
        if (selected == 0)
        {
            return "yellow";
        }
        else if (selected == 1)
        {
            return "red";
        }
        else if (selected == 2)
        {
            return "purple";
        }
        else if (selected == 4)
        {
            return "blue";
        }
        return "";
    }
	

    public void ChangeNextColor(){
        if(theChoosenOne >= 3){
            theChoosenOne = 0;
        }else {
            theChoosenOne++;
        }

        theChild.GetComponent<MeshRenderer>().material = materials[theChoosenOne];
    }

	//private void Update()
	//{
 //       if(Input.GetKeyDown(KeyCode.N)){
 //           ChangeNextColor();
 //       }
	//}
}
