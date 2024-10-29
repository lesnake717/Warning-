using UnityEngine;
using UnityEngine.Video;

public class GestionGenenerique : MonoBehaviour
{
    public VideoPlayer videoGenerique;
    [SerializeField] private GestionBoutonJouer gestionBoutonJouer;

    void Start()
    {
        videoGenerique.loopPointReached += FinGenerique;
        Debug.Log("Vid�o g�n�rique est pr�te � jouer");
    }

    void FinGenerique(VideoPlayer vp)
    {
        if (gestionBoutonJouer != null)
        {
            Debug.Log("Vid�o g�n�rique a fini de jouer, affichage du bouton");
            gestionBoutonJouer.AfficherBouton();
        }
        else
            Debug.LogError("GestionBoutonJouer n'est pas assign� dans l'inspecteur.");
    }
}