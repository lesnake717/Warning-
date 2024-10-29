using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GestionBoutonJouer : MonoBehaviour
{
    public GameObject boutonJouer;

    void Start()
    {
        boutonJouer.SetActive(false);
        boutonJouer.GetComponent<Button>().onClick.AddListener(ChargerSceneInscriptionConnexion);
    }

    public void AfficherBouton()
    {
        boutonJouer.SetActive(true);
    }

    void ChargerSceneInscriptionConnexion()
    {
        // Chargement direct de la sc�ne de connexion
        SceneManager.LoadScene("LoginAndSignup");
    }
}