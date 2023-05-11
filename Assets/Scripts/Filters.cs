using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filters : MonoBehaviour
{
    public GameObject librarian, trainer, barista, professor, chef;
    public GameObject librarianSkeleton, trainerSkeleton, baristaSkeleton, professorSkeleton, chefSkeleton;

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
            
            librarianMats = librarianRenderer.materials;
            librarianRenderer.materials = xrayMat;
            librarianSkeleton.SetActive(true);

            trainerMats = trainerRenderer.materials;
            trainerRenderer.materials = xrayMat;
            trainerSkeleton.SetActive(true);

            baristaMats = baristaRenderer.materials;
            baristaRenderer.materials = xrayMat;
            baristaSkeleton.SetActive(true);

        } else if (filterOn) {
            filterOn = false;

            librarianRenderer.materials = librarianMats;
            trainerRenderer.materials = trainerMats;
            baristaRenderer.materials = baristaMats;

            librarianSkeleton.SetActive(false);
            trainerSkeleton.SetActive(false);
            baristaSkeleton.SetActive(false);
        }
    }
}
