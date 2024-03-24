using UnityEngine;
using UnityEngine.UI;

public class ChangerAnimatorController : MonoBehaviour
{
    public RuntimeAnimatorController bulbizarreController;
    public RuntimeAnimatorController spoinkController;
    public RuntimeAnimatorController salamecheController;
    public RuntimeAnimatorController carapuceController;
    public RuntimeAnimatorController herbizarreController;
    public RuntimeAnimatorController florizarreController;
    public RuntimeAnimatorController reptincelController;
    public RuntimeAnimatorController dracaufeuController;
    public RuntimeAnimatorController carabaffeController;
    public RuntimeAnimatorController tortankController;








    private Image imageComponent;
    private Animator animator;

    private void Start()
    {
        imageComponent = GetComponent<Image>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (imageComponent.sprite != null)
        {
            string imageName = imageComponent.sprite.name;
            if (imageName.Contains("Bulbizarre"))
            {
                SetAnimatorController(bulbizarreController);
            }
            else if (imageName.Contains("Spoink"))
            {
                SetAnimatorController(spoinkController);
            }
            else if (imageName.Contains("Salameche"))
            {
                SetAnimatorController(salamecheController);
            }
            else if (imageName.Contains("Carapuce"))
            {
                SetAnimatorController(carapuceController);
            }
            else if (imageName.Contains("Herbizarre"))
            {
                SetAnimatorController(herbizarreController);
            }
            else if (imageName.Contains("Florizarre"))
            {
                SetAnimatorController(florizarreController);
            }
            else if (imageName.Contains("Reptincel"))
            {
                SetAnimatorController(reptincelController);
            }
            else if (imageName.Contains("Dracaufeu"))
            {
                SetAnimatorController(dracaufeuController);
            }
            else if (imageName.Contains("Carabaffe"))
            {
                SetAnimatorController(carabaffeController);
            }
            else if (imageName.Contains("Tortank"))
            {
                SetAnimatorController(tortankController);
            }
        }
    }

    private void SetAnimatorController(RuntimeAnimatorController controller)
    {
        if (controller != null)
        {
            animator.runtimeAnimatorController = controller;
            animator.enabled = true;
        }
    }
}
