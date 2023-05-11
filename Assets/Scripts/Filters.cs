using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filters : MonoBehaviour
{
    public GameObject librarian, trainer, barista, professor, chef;
    public SkinnedMeshRenderer librarianRenderer, trainerRenderer, baristaRenderer, professorRenderer, chefRenderer;
    public Material[] librarianMats, trainerMats, baristaMats, professorMats, chefMats;
    
    public Material[] xrayMat;
    
    bool filterOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void XRayFilter(){
        if (!filterOn) {
            filterOn = true;
            Debug.Log("xray is on");
            
            librarianRenderer = librarian.transform.GetChild(2).GetComponent<SkinnedMeshRenderer>();
            trainerRenderer = trainer.transform.GetChild(2).GetComponent<SkinnedMeshRenderer>();
            baristaRenderer = barista.transform.GetChild(2).GetComponent<SkinnedMeshRenderer>();
            
            librarianMats = librarianRenderer.materials;
            trainerMats = trainerRenderer.materials;
            baristaMats = baristaRenderer.materials;

            librarianRenderer.materials = xrayMat;
            trainerRenderer.materials = xrayMat;
            baristaRenderer.materials = xrayMat;

            Debug.Log("mesh should be updated");

        } else if (filterOn) {
            filterOn = false;
            Debug.Log("xray is off");

            librarianRenderer.materials = librarianMats;
            trainerRenderer.materials = trainerMats;
            baristaRenderer.materials = baristaMats;
        }
    }
}
