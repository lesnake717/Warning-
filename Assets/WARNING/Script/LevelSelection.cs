using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] lvlButtons;
    private Color disabledColor = new Color(0.8f, 0.8f, 0.8f); // Couleur l�g�rement grise pour les niveaux d�sactiv�s

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        // D�sactiver tous les boutons de niveau au d�part et les grisers l�g�rement
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            lvlButtons[i].interactable = false;
            ColorBlock colorBlock = lvlButtons[i].colors;
            colorBlock.disabledColor = disabledColor;
            lvlButtons[i].colors = colorBlock;
        }

        // Activer uniquement le bouton correspondant au niveau de d�part
        if (levelAt >= 2 && levelAt <= lvlButtons.Length + 1)
        {
            int levelIndex = levelAt - 2;
            lvlButtons[levelIndex].interactable = true;
            ColorBlock colorBlock = lvlButtons[levelIndex].colors;
            colorBlock.disabledColor = Color.white; // R�tablir la couleur normale pour le niveau activ�
            lvlButtons[levelIndex].colors = colorBlock;
        }
    }
}