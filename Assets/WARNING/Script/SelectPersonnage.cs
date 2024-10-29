using UnityEngine;
using UnityEngine.EventSystems;

public class SelectPersonnage : MonoBehaviour, IPointerClickHandler
{
    public int numeroPersonnage;

    public void OnPointerClick(PointerEventData evenementData)
    {
        // Enregistrer le num�ro du personnage s�lectionn� dans PlayerPrefs avec la cl� "PersonnageChoisiIndex"
        PlayerPrefs.SetInt("PersonnageChoisiIndex", numeroPersonnage);
    }
}