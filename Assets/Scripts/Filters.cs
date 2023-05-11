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
            
            librarianRenderer = librarian.transform.GetChild(2).GetComponent<SkinnedMeshRenderer>();
            trainerRenderer = trainer.transform.GetChild(2).GetComponent<SkinnedMeshRenderer>();
            baristaRenderer = barista.transform.GetChild(2).GetComponent<SkinnedMeshRenderer>();
            
            if (librarianRenderer != null) {
                librarianMats = librarianRenderer.materials;
                librarianRenderer.materials = xrayMat;
            }
            if (trainerRenderer != null) {
                trainerMats = trainerRenderer.materials;
                trainerRenderer.materials = xrayMat;
            }
            if (baristaRenderer != null) {
                baristaMats = baristaRenderer.materials;
                baristaRenderer.materials = xrayMat;
            }

        } else if (filterOn) {
            filterOn = false;

            if (librarianRenderer != null) {
                librarianRenderer.materials = librarianMats;
            }
            if (trainerRenderer != null) {
                trainerRenderer.materials = trainerMats;
            }
            if (baristaRenderer != null) {
                baristaRenderer.materials = baristaMats;
            }

        }
    }
}
